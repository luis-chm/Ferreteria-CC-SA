using Ferreteria_CC_SA.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria_CC_SA.Controllers
{
    /// <summary>
    /// Represents the model of a cashier controller
    /// </summary>
    /// <seealso cref="Ferreteria_CC_SA.Controllers.ICajeroController" />
    public class CajeroController : ICajeroController
    {
        /// <summary>
        /// A list of cashiers
        /// </summary>
        private List<ICajero> cajeros;
        /// <summary>
        /// The file handler
        /// </summary>
        private readonly IFileHandler fileHandler;
        /// <summary>
        /// Initializes a new instance of the <see cref="CajeroController"/> class.
        /// </summary>
        /// <param name="fileHandler">The file handler.</param>
        public CajeroController(IFileHandler fileHandler)
        {
            cajeros = new List<ICajero>();
            this.fileHandler = fileHandler;
        }
        /// <summary>
        /// Gets the cashier.
        /// </summary>
        /// <returns></returns>
        public List<ICajero> GetCashier()
        {
            return cajeros;
        }
        /// <summary>
        /// Loads the cashier.
        /// </summary>
        /// <param name="path">The path.</param>
        public void LoadCashier(string path)
        {
            cajeros.Clear();
            try
            {
                if (!File.Exists(path))
                {
                    string header = "IDCajero,Nombre,Apellido,Usuario,Contrasena\n";
                    fileHandler.CreateNewFile(path, header);
                    MessageBox.Show("El archivo de cajeros no se encontró y se creó uno nuevo.\nPor favor, ingrese con usuario administrador.");
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
                            var cajero = new Cajero
                            {
                                IDCajero = int.Parse(parts[0].Trim()),
                                Nombre = parts[1].Trim(),
                                Apellido = parts[2].Trim(),
                                Usuario = parts[3].Trim(),
                                Contrasena = parts[4].Trim()
                            };
                            cajeros.Add(cajero);
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
                MessageBox.Show($"Error al cargar cajeros: {ex.Message}");
            }
        }
        /// <summary>
        /// Saves the cashier.
        /// </summary>
        /// <param name="path">The path.</param>
        public void SaveCashier(string path)
        {
            try
            {
                var lines = new List<string>
            {
                "IDCajero,Nombre,Apellido,Usuario,Contrasena"
            };

                foreach (var c in cajeros)
                {
                    lines.Add($"{c.IDCajero},{c.Nombre},{c.Apellido},{c.Usuario},{c.Contrasena}");
                }

                fileHandler.WriteAllLines(path, lines.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar cajeros: {ex.Message}");
            }
        }
        /// <summary>
        /// Adds the cashier.
        /// </summary>
        /// <param name="cajero">The cajero.</param>
        /// <returns></returns>
        public bool AddCashier(ICajero cajero)
        {
            if (cajeros.Any(c => c.IDCajero == cajero.IDCajero))
            {
                MessageBox.Show($"El cajero con ID {cajero.IDCajero} ya existe. Por favor ingrese otro.");
                return false;
            }
            cajeros.Add(cajero);
            return true;
        }

        /// <summary>
        /// Edits the cashier.
        /// </summary>
        /// <param name="cajero">The cajero.</param>
        public void EditCashier(ICajero cajero)
        {
            try
            {
                var actualCashier = cajeros.FirstOrDefault(c => c.IDCajero == cajero.IDCajero);
                if (actualCashier != null)
                {
                    actualCashier.Nombre = cajero.Nombre;
                    actualCashier.Apellido = cajero.Apellido;
                    actualCashier.Usuario = cajero.Usuario;
                    actualCashier.Contrasena = cajero.Contrasena;
                    SaveCashier("cajeros.csv");
                }
                else
                {
                    MessageBox.Show("El cajero con el ID proporcionado no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar cajero: {ex.Message}");
            }
        }
        /// <summary>
        /// Deletes the cashier.
        /// </summary>
        /// <param name="idCajero">The identifier cajero.</param>
        public void DeleteCashier(int idCajero)
        {
            try
            {
                var cajero = cajeros.FirstOrDefault(c => c.IDCajero == idCajero);
                if (cajero != null)
                {
                    cajeros.Remove(cajero);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar cajero: {ex.Message}");
            }
        }
        /// <summary>
        /// Finds the cashier by identifier.
        /// </summary>
        /// <param name="idCajero">The identifier cajero.</param>
        /// <returns></returns>
        public ICajero FindCashierByID(int idCajero)
        {
            return cajeros.FirstOrDefault(c => c.IDCajero == idCajero);
        }
        /// <summary>
        /// Checks the cashier by parameters
        /// </summary>
        /// <param name="usuario">The usuario.</param>
        /// <param name="contrasena">The contrasena.</param>
        /// <returns></returns>
        public bool CheckCashier(string usuario, string contrasena)
        {
            return cajeros.Any(c => c.Usuario == usuario && c.Contrasena == contrasena);
        }
        /// <summary>
        /// Generates the initial cashiers.
        /// </summary>
        /// <param name="path">The path.</param>
        public void GenerateInitialCashiers(string path)
        {
            var initialCashiers = new List<ICajero>
                {
                    new Cajero { IDCajero = 1, Nombre = "Cajero", Apellido = "00", Usuario = "admin", Contrasena = "1234" }
                };
            cajeros.Clear();
            cajeros.AddRange(initialCashiers);
            SaveCashier(path);
        }
    }
}
