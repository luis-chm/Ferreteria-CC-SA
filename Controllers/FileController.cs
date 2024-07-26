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
    /// <summary>
    /// Represents the model of a File controller
    /// </summary>
    /// <seealso cref="Ferreteria_CC_SA.Controllers.IFileHandler" />
    public class FileController : IFileHandler
    {
        /// <summary>
        /// Loads the file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public string LoadFile(string path)
        {
            return File.ReadAllText(path);
        }
        /// <summary>
        /// Writes all lines.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="lines">The lines.</param>
        public void WriteAllLines(string filePath, string[] lines)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                foreach (var line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }
        /// <summary>
        /// Creates the new file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="header">The header.</param>
        public void CreateNewFile(string path, string header)
        {
            using (var stream = File.Create(path))
            {
                byte[] headerBytes = new UTF8Encoding(true).GetBytes(header);
                stream.Write(headerBytes, 0, headerBytes.Length);
            }
        }
    }
}
