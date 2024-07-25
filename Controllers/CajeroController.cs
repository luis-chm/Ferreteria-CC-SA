using Ferreteria_CC_SA.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria_CC_SA.Controllers
{
    public class CajeroController : ICajeroController
    {
        private List<ICajero> cajeros;

        public CajeroController()
        {
            cajeros = new List<ICajero>();
        }
        public List<ICajero> GetCashier()
        {
            return cajeros;
        }
        private void CreateNewFile(string path)
        {
            using (var stream = File.Create(path))
            {
                string header = "IDCajero,Nombre,Apellido,Usuario,Contrasena\n";
                byte[] headerBytes = new UTF8Encoding(true).GetBytes(header);
                stream.Write(headerBytes, 0, headerBytes.Length);
                MessageBox.Show("El archivo de cajeros no se encontró y se creó uno nuevo. Por favor, agregue cajeros.");
                return;
            }
        }
        public void LoadCashier(string path)
        {
            cajeros.Clear();
            try
            {
                if (!File.Exists(path))
                {
                    CreateNewFile(path);
                }
                var content = File.ReadAllText(path);
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
                File.WriteAllLines(path, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar cajeros: {ex.Message}");
            }
        }
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
        public void EditCashier(ICajero cajero)
        {
            try
            {
                var caj = cajeros.FirstOrDefault(c => c.IDCajero == cajero.IDCajero);
                if (caj != null)
                {
                    caj.IDCajero = cajero.IDCajero;
                    caj.Nombre = cajero.Nombre;
                    caj.Apellido = cajero.Apellido;
                    caj.Usuario = cajero.Usuario;
                    caj.Contrasena = cajero.Contrasena;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar cajero: {ex.Message}");
            }
        }
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
        public ICajero FindCashierByID(int idCajero)
        {
            return cajeros.FirstOrDefault(c => c.IDCajero == idCajero);
        }
        public bool CheckLogin(string usuario, string contrasena)
        {
            return cajeros.Any(c => c.Usuario == usuario && c.Contrasena == contrasena);
        }
    }
}
