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
    /// Descripción breve de wsCargador
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsCargador : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar la tabla cargador")]
        public DataSet Listar()
        {
            Cargador cargador = new Cargador();
            return cargador.Listar();
        }

        [WebMethod(Description = "Buscar en la tabla cargador")]
        public DataSet Buscar(string texto, string criterio)
        {
            Cargador cargador = new Cargador();
            return cargador.Buscar(texto, criterio);
        }
    }
}
