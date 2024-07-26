using Ferreteria_CC_SA.Models;
using System.Collections.Generic;
using System.IO;

namespace Ferreteria_CC_SA.Controllers
{
    /// <summary>
    /// Defines the operations for managing Files
    /// </summary>
    public interface IFileHandler
    {
        /// <summary>
        /// Loads the file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        string LoadFile(string path);
        /// <summary>
        /// Writes all lines.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="lines">The lines.</param>
        void WriteAllLines(string filePath, string[] lines);
        /// <summary>
        /// Creates the new file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="header">The header.</param>
        void CreateNewFile(string path, string header);
    }
}