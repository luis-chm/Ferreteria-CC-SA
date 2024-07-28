using Ferreteria_CC_SA.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Ferreteria_CC_SA.Controllers
{
    /// <summary>
    /// Represents the model of a client controller
    /// </summary>
    /// <seealso cref="Ferreteria_CC_SA.Controllers.IClienteController" />
    public class ClienteController : IClienteController
    {
        /// <summary>
        /// Listo of clients
        /// </summary>
        private List<ICliente> clientes;
        /// <summary>
        /// The filepath
        /// </summary>
        private static readonly string Filepath = "clientes.csv";
        /// <summary>
        /// The file handler
        /// </summary>
        private IFileHandler fileHandler;
        /// <summary>
        /// Initializes a new instance of the <see cref="ClienteController" /> class.
        /// </summary>
        /// <param name="fileHandler">The file handler.</param>
        public ClienteController(IFileHandler fileHandler)
        {
            clientes = new List<ICliente>();
            this.fileHandler = fileHandler;
        }
        /// <summary>
        /// Gets the clients.
        /// </summary>
        /// <returns></returns>
        public List<ICliente> GetClients()
        {
            return clientes;
        }
        /// <summary>
        /// Loads the client.
        /// </summary>
        /// <exception cref="System.Exception">
        /// Error en el formato de una línea del archivo: {ex.Message}\nLínea problemática: {line}
        /// or
        /// Error al procesar una línea del archivo: {ex.Message}\nLínea problemática: {line}
        /// </exception>
        public void LoadClient()
        {
            clientes.Clear();
            try
            {
                if (!File.Exists(Filepath))
                {
                    string header = "IDCliente,Nombre,Apellido,Correo,Telefono\n";
                    fileHandler.CreateNewFile(Filepath, header);
                    MessageBox.Show("El archivo de clientes no se encontró y se creó uno nuevo. Por favor, agregue clientes.");
                    return;
                }

                var content = fileHandler.LoadFile(Filepath);
                var lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var line in lines.Skip(1))
                {
                    var parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        try
                        {
                            var cliente = new Cliente
                            {
                                IDCliente = int.Parse(parts[0].Trim()),
                                Nombre = parts[1].Trim(),
                                Apellido = parts[2].Trim(),
                                Correo = parts[3].Trim(),
                                Telefono = parts[4].Trim()
                            };
                            clientes.Add(cliente);
                        }
                        catch (FormatException ex)
                        {
                            throw new Exception($"Error en el formato de una línea del archivo: {ex.Message}\nLínea problemática: {line}");
                        }
                        catch (Exception ex)
                        {
                            throw new Exception($"Error al procesar una línea del archivo: {ex.Message}\nLínea problemática: {line}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}");
            }
        }
        /// <summary>
        /// Saves the client.
        /// </summary>
        /// <exception cref="System.Exception">Error al guardar cliente: {ex.Message}</exception>
        public void SaveClient()
        {
            try
            {
                var lines = new List<string>
                {
                    "IDCliente,Nombre,Apellido,Correo,Telefono"
                };

                foreach (var c in clientes)
                {
                    lines.Add($"{c.IDCliente},{c.Nombre},{c.Apellido},{c.Correo},{c.Telefono}");
                }
                fileHandler.WriteAllLines(Filepath, lines.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar cliente: {ex.Message}");
            }
        }
        /// <summary>
        /// Adds the client.
        /// </summary>
        /// <param name="cliente">The cliente.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">
        /// El cliente con ID {cliente.IDCliente} ya existe. Por favor ingrese otro.
        /// or
        /// Error al agregar cliente: {ex.Message}
        /// </exception>
        public bool AddClient(ICliente cliente)
        {
            try
            {
                if (clientes.Any(c => c.IDCliente == cliente.IDCliente))
                {
                    throw new Exception($"El cliente con ID {cliente.IDCliente} ya existe. Por favor ingrese otro.");
                }
                clientes.Add(cliente);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar cliente: {ex.Message}");
            }
        }
        /// <summary>
        /// Edits the client.
        /// </summary>
        /// <param name="cliente">The cliente.</param>
        /// <exception cref="System.Exception">
        /// El cliente con el ID proporcionado no existe.
        /// or
        /// Error al editar cliente: {ex.Message}
        /// </exception>
        public void EditClient(ICliente cliente)
        {
            try
            {
                var client = clientes.FirstOrDefault(c => c.IDCliente == cliente.IDCliente);

                if (client != null)
                {
                    client.Nombre = cliente.Nombre;
                    client.Apellido = cliente.Apellido;
                    client.Correo = cliente.Correo;
                    client.Telefono = cliente.Telefono;
                    SaveClient();
                }
                else
                {
                    throw new Exception("El cliente con el ID proporcionado no existe.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al editar cliente: {ex.Message}");
            }
        }
        /// <summary>
        /// Deletes the client.
        /// </summary>
        /// <param name="idCliente">The identifier cliente.</param>
        /// <exception cref="System.Exception">
        /// El cliente con el ID proporcionado no existe.
        /// or
        /// Error al eliminar cliente: {ex.Message}
        /// </exception>
        public void DeleteClient(int idCliente)
        {
            try
            {
                var cliente = clientes.FirstOrDefault(c => c.IDCliente == idCliente);
                if (cliente != null)
                {
                    clientes.Remove(cliente);
                }
                else
                {
                    throw new Exception("El cliente con el ID proporcionado no existe.");

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar cliente: {ex.Message}");
            }
        }
        /// <summary>
        /// Finds the cliente by identifier.
        /// </summary>
        /// <param name="idCliente">The identifier cliente.</param>
        /// <returns></returns>
        public ICliente FindClienteByID(int idCliente)
        {
            return clientes.FirstOrDefault(c => c.IDCliente == idCliente);
        }
    }
}
