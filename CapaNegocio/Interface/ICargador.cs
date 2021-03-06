using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Interface
{
    interface ICargador
    {
        //declarar metodos de la interfaz que permitan implementar el CRUD
        DataSet Listar();
        bool Agregar();
        bool Eliminar();
        bool Actualizar();
        DataSet Buscar(string texto, string criterio);
    }
}