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
        /// The filepath for csv file
        /// </summary>
        private static readonly string Filepath = "cajeros.csv";
        /// <summary>
        /// The file handler
        /// </summary>
        private readonly IFileHandler fileHandler;
        /// <summary>
        /// Initializes a new instance of the <see cref="CajeroController" /> class.
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
        /// <exception cref="System.IO.FileNotFoundException">El archivo de cajeros no se encontró y se creó uno nuevo.\nPor favor, ingrese con usuario administrador.</exception>
        /// <exception cref="System.Exception">
        /// Error en el formato de una línea del archivo: {ex.Message}\nLínea problemática: {line}
        /// or
        /// Línea mal formateada en el archivo: {line}
        /// or
        /// Error: {ex.Message}
        /// </exception>
        public void LoadCashier()
        {
            cajeros.Clear();
            try
            {
                if (!File.Exists(Filepath))
                {
                    string header = "IDCajero,Nombre,Apellido,Usuario,Contrasena\n";
                    fileHandler.CreateNewFile(Filepath, header);
                    throw new FileNotFoundException("El archivo de cajeros no se encontró y se creó uno nuevo.\nPor favor, ingrese con usuario administrador.");
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
                            throw new Exception($"Error en el formato de una línea del archivo: {ex.Message}\nLínea problemática: {line}");
                        }
                    }
                    else
                    {
                        throw new Exception($"Línea mal formateada en el archivo: {line}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
        /// <summary>
        /// Saves the cashier.
        /// </summary>
        /// <exception cref="System.Exception">Error al guardar cajero: {ex.Message}</exception>
        public void SaveCashier()
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

                fileHandler.WriteAllLines(Filepath, lines.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar cajero: {ex.Message}");
            }
        }
        /// <summary>
        /// Adds the cashier.
        /// </summary>
        /// <param name="cajero">The cajero.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">El cajero con ID {cajero.IDCajero} ya existe. Por favor ingrese otro.</exception>
        public bool AddCashier(ICajero cajero)
        {
            if (cajeros.Any(c => c.IDCajero == cajero.IDCajero))
            {
                throw new ArgumentException($"El cajero con ID {cajero.IDCajero} ya existe. Por favor ingrese otro.");
            }
            cajeros.Add(cajero);
            return true;
        }

        /// <summary>
        /// Edits the cashier.
        /// </summary>
        /// <param name="cajero">The cajero.</param>
        /// <exception cref="System.Exception">El cajero con el ID proporcionado no existe.</exception>
        /// <exception cref="System.Collections.Generic.KeyNotFoundException">Error al editar cajero</exception>
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
                    SaveCashier();
                }
                else
                {
                    throw new Exception("El cajero con el ID proporcionado no existe.");
                }
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException("Error al editar cajero");
            }
        }
        /// <summary>
        /// Deletes the cashier.
        /// </summary>
        /// <param name="idCajero">The identifier cajero.</param>
        /// <exception cref="System.Exception">
        /// El cajero con el ID proporcionado no existe.
        /// or
        /// Error al eliminar cajero: {ex.Message}
        /// </exception>
        public void DeleteCashier(int idCajero)
        {
            try
            {
                var cajero = cajeros.FirstOrDefault(c => c.IDCajero == idCajero);
                if (cajero != null)
                {
                    cajeros.Remove(cajero);
                }
                else
                {
                    throw new Exception("El cajero con el ID proporcionado no existe.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar cajero: {ex.Message}");
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
        public void GenerateInitialCashiers()
        {
            var initialCashiers = new List<ICajero>
                {
                    new Cajero { IDCajero = 1, Nombre = "Cajero", Apellido = "00", Usuario = "admin", Contrasena = "1234" }
                };
            cajeros.Clear();
            cajeros.AddRange(initialCashiers);
            SaveCashier();
        }
    }
}
