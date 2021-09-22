using CapaDato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Empleado : Interface.IEmpleado
    {
        private Datos datos = new DatosSQL();
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }

       

        //atributos de clase 
        private int id;
        private string apellido;
        private string nombre;
        private string titulo;
        private string tituloCortesia;
        private DateTime fechaNacimiento;
        private DateTime fechaContrata;
        private string direccion;
        private string ciudad;
        private string region;
        private string codPostal;
        private string pais;
        private string telefono;
        private string extension;
        private ImageFileMachine foto;
        private string nota;
        private int reportes;
        private string direcFoto;

        //metodos getter and setter
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string TituloCortesia { get => tituloCortesia; set => tituloCortesia = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public DateTime FechaContrata { get => fechaContrata; set => fechaContrata = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Region { get => region; set => region = value; }
        public string CodPostal { get => codPostal; set => codPostal = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Extension { get => extension; set => extension = value; }
        public ImageFileMachine Foto { get => foto; set => foto = value; }
        public string Nota { get => nota; set => nota = value; }
        public int Reportes { get => reportes; set => reportes = value; }
        public string DirecFoto { get => direcFoto; set => direcFoto = value; }
        public int Id { get => id; set => id = value; }

        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarEmpleado", Id, Apellido,nombre,titulo,tituloCortesia,
                fechaNacimiento,fechaContrata,direccion,ciudad,region,codPostal,pais,telefono,extension,foto,
                nota,reportes,direcFoto);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public bool Agregar()
        {
            DataRow fila = datos.TraerDataRow("spAgregarEmpleado", Id, Apellido, nombre, titulo, tituloCortesia,
                fechaNacimiento, fechaContrata, direccion, ciudad, region, codPostal, pais, telefono, extension, foto,
                nota, reportes, direcFoto);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarEmpleado", texto, criterio);
        }

        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarEmpleado", Id);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarEmpleado");
        }
    }
}
