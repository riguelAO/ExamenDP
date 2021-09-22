using CapaDato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Cargador : Interface.ICargador
    {
        private Datos datos = new DatosSQL();
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }
    

        //atributos de clase
        private int id;
        private string NombreCompa;
        private string celular;
        //metodos getter and setter
        public int Id { get => id; set => id = value; }
        public string NombreCompa1 { get => NombreCompa; set => NombreCompa = value; }
        public string Celular { get => celular; set => celular = value; }

        //ejecuciond e los procedimientos almacenados
        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarCargador", Id, NombreCompa,celular);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Agregar()
        {
            DataRow fila = datos.TraerDataRow("spAgregarCargador", Id, NombreCompa, celular);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarCargador", texto, criterio);
        }

        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarCargador", Id);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarCargador");
        }
    }
}
