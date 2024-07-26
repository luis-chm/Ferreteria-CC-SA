using Ferreteria_CC_SA.Models;
using System.Collections.Generic;

namespace Ferreteria_CC_SA.Controllers
{
    /// <summary>
    /// Defines the operations for managing Clients
    /// </summary>
    public interface IClienteController
    {
        /// <summary>
        /// Gets the clients.
        /// </summary>
        /// <returns></returns>
        List<ICliente> GetClients();
        /// <summary>
        /// Loads the client.
        /// </summary>
        /// <param name="path">The path.</param>
        void LoadClient(string path);
        /// <summary>
        /// Saves the client.
        /// </summary>
        /// <param name="path">The path.</param>
        void SaveClient(string path);
        /// <summary>
        /// Adds the client.
        /// </summary>
        /// <param name="cliente">The cliente.</param>
        /// <returns></returns>
        bool AddClient(ICliente cliente);
        /// <summary>
        /// Edits the client.
        /// </summary>
        /// <param name="cliente">The cliente.</param>
        /// <param name="oldID">The old identifier.</param>
        void EditClient(ICliente cliente);
        /// <summary>
        /// Deletes the client.
        /// </summary>
        /// <param name="idCliente">The identifier cliente.</param>
        void DeleteClient(int idCliente);
        /// <summary>
        /// Finds the cliente by identifier.
        /// </summary>
        /// <param name="idCliente">The identifier cliente.</param>
        /// <returns></returns>
        ICliente FindClienteByID(int idCliente);
    }
}