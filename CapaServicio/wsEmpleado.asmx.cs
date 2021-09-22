using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Services;

using CapaNegocio;
using System.Data;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de wsEmpleado
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsEmpleado : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar la tabla empleado")]
        public DataSet Listar()
        {
            Empleado empleado = new Empleado();
            return empleado.Listar();
        }

        [WebMethod(Description = "Buscar en la tabla empleado")]
        public DataSet Buscar(string texto, string criterio)
        {
            Empleado empleado = new Empleado();
            return empleado.Buscar(texto, criterio);
        }
    }
}
