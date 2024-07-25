using Ferreteria_CC_SA.Models;
using System.Collections.Generic;

namespace Ferreteria_CC_SA.Controllers
{
    public interface ICajeroController
    {
        List<ICajero> GetCashier();
        void LoadCashier(string path);
        void SaveCashier(string path);
        bool AddCashier(ICajero cajero);
        void EditCashier(ICajero cajero);
        void DeleteCashier(int idcajero);
        ICajero FindCashierByID(int idcajero);
        bool CheckLogin(string usuario, string contrasena);
    }
}