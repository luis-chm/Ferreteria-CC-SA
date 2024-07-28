using Ferreteria_CC_SA.Models;
using System.Collections.Generic;

namespace Ferreteria_CC_SA.Controllers
{
    /// <summary>
    /// Defines the operations for managing Cashiers
    /// </summary>
    public interface ICajeroController
    {
        /// <summary>
        /// Gets the cashier.
        /// </summary>
        /// <returns></returns>
        List<ICajero> GetCashier();
        /// <summary>
        /// Loads the cashier.
        /// </summary>
        void LoadCashier();
        /// <summary>
        /// Saves the cashier.
        /// </summary>
        void SaveCashier();
        /// <summary>
        /// Adds the cashier.
        /// </summary>
        /// <param name="cajero">The cajero.</param>
        /// <returns></returns>
        bool AddCashier(ICajero cajero);
        /// <summary>
        /// Edits the cashier.
        /// </summary>
        /// <param name="cajero">The cajero.</param>
        void EditCashier(ICajero cajero);
        /// <summary>
        /// Deletes the cashier.
        /// </summary>
        /// <param name="idCajero">The identifier cajero.</param>
        void DeleteCashier(int idCajero);
        /// <summary>
        /// Finds the cashier by identifier.
        /// </summary>
        /// <param name="idCajero">The identifier cajero.</param>
        /// <returns></returns>
        ICajero FindCashierByID(int idCajero);
        /// <summary>
        /// Checks the cashier.
        /// </summary>
        /// <param name="usuario">The usuario.</param>
        /// <param name="contrasena">The contrasena.</param>
        /// <returns></returns>
        bool CheckCashier(string usuario, string contrasena);
        /// <summary>
        /// Generates the initial cashiers.
        /// </summary>
        void GenerateInitialCashiers();
    }
}