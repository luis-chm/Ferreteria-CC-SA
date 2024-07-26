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
        /// The file handler
        /// </summary>
        private IFileHandler fileHandler;
        /// <summary>
        /// Initializes a new instance of the <see cref="ClienteController"/> class.
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
        /// <param name="path">The path.</param>
        public void LoadClient(string path)
        {
            clientes.Clear();
            try
            {
                if (!File.Exists(path))
                {
                    string header = "IDCliente,Nombre,Apellido,Correo,Telefono\n";
                    fileHandler.CreateNewFile(path, header);
                    MessageBox.Show("El archivo de clientes no se encontró y se creó uno nuevo. Por favor, agregue clientes.");
                    return;
                }

                var content = fileHandler.LoadFile(path);
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
                            MessageBox.Show($"Error en el formato de una línea del archivo: {ex.Message}\nLínea problemática: {line}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al procesar una línea del archivo: {ex.Message}\nLínea problemática: {line}");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Línea mal formateada en el archivo: {line}");
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
        /// <param name="path">The path.</param>
        public void SaveClient(string path)
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
                fileHandler.WriteAllLines(path, lines.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar clientes: {ex.Message}");
            }
        }
        /// <summary>
        /// Adds the client.
        /// </summary>
        /// <param name="cliente">The cliente.</param>
        /// <returns></returns>
        public bool AddClient(ICliente cliente)
        {
            if (clientes.Any(c => c.IDCliente == cliente.IDCliente))
            {
                MessageBox.Show($"El cliente con ID {cliente.IDCliente} ya existe. Por favor ingrese otro.");
                return false;
            }
            clientes.Add(cliente);
            return true;
        }
        /// <summary>
        /// Edits the client.
        /// </summary>
        /// <param name="cliente">The cliente.</param>
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
                    SaveClient("clientes.csv");
                }
                else
                {
                    MessageBox.Show("El cliente con el ID proporcionado no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar cliente: {ex.Message}");
            }
        }
        /// <summary>
        /// Deletes the client.
        /// </summary>
        /// <param name="idCliente">The identifier cliente.</param>
        public void DeleteClient(int idCliente)
        {
            try
            {
                var cliente = clientes.FirstOrDefault(c => c.IDCliente == idCliente);
                if (cliente != null)
                {
                    clientes.Remove(cliente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar cliente: {ex.Message}");
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
