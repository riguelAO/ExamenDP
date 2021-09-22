using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class frmEmpleado : System.Web.UI.Page
    {
        private Empleado empleado = new Empleado();
        private void Listar()
        {
            gvEmpleado.DataSource = empleado.Listar().Tables[0];
            gvEmpleado.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }


        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text.Trim());
            string Nombre = txtNombre.Text.Trim();
            string Apellido = txtApellido.Text.Trim();
            string titulo = txtTitulo.Text.Trim();
            string tituloCor = txtTituloCor.Text.Trim();
            DateTime fecNacimiento = Convert.ToDateTime(txtFecNac.Text);
            DateTime fecContrata = Convert.ToDateTime(txtFecCon.Text);
            string direccion = txtDireccion.Text.Trim();
            string ciudad = txtCiudad.Text.Trim();
            string region = txtRegion.Text.Trim();
            string codPostal = txtCodPostal.Text.Trim();
            string pais = txtPais.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string Extension = txtExtension.Text.Trim();
            string notas = txtNota.Text.Trim();
            int reportes = int.Parse(txtReportes.Text.Trim());
            string direcFoto = txtDirecFoto.Text.Trim();

            empleado.Id = id; empleado.Nombre = Nombre; empleado.Apellido = Apellido; empleado.Titulo = titulo;
            empleado.TituloCortesia = tituloCor; empleado.FechaNacimiento = fecNacimiento;
            empleado.FechaContrata = fecContrata; empleado.Direccion = direccion; empleado.Ciudad = ciudad;
            empleado.CodPostal = codPostal; empleado.Pais = pais; empleado.Telefono = telefono; empleado.Extension = Extension;
            empleado.Nota = notas; empleado.Reportes = reportes; empleado.DirecFoto = direcFoto;

            if (empleado.Agregar() == true)
                Listar();
            Response.Write("<script>alert('" + empleado.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text.Trim());
            empleado.Id = id;
            if (empleado.Eliminar() == true)
                Listar();
            Response.Write("<script>alert('" + empleado.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text.Trim());
            string Nombre = txtNombre.Text.Trim();
            string Apellido = txtApellido.Text.Trim();
            string titulo = txtTitulo.Text.Trim();
            string tituloCor = txtTituloCor.Text.Trim();
            DateTime fecNacimiento = Convert.ToDateTime(txtFecNac.Text);
            DateTime fecContrata = Convert.ToDateTime(txtFecCon.Text);
            string direccion = txtDireccion.Text.Trim();
            string ciudad = txtCiudad.Text.Trim();
            string region = txtRegion.Text.Trim();
            string codPostal = txtCodPostal.Text.Trim();
            string pais = txtPais.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string Extension = txtExtension.Text.Trim();
            string notas = txtNota.Text.Trim();
            int reportes = int.Parse(txtReportes.Text.Trim());
            string direcFoto = txtDirecFoto.Text.Trim();

            empleado.Id = id; empleado.Nombre = Nombre; empleado.Apellido = Apellido; empleado.Titulo = titulo;
            empleado.TituloCortesia = tituloCor; empleado.FechaNacimiento = fecNacimiento;
            empleado.FechaContrata = fecContrata; empleado.Direccion = direccion; empleado.Ciudad = ciudad;
            empleado.CodPostal = codPostal; empleado.Pais = pais; empleado.Telefono = telefono; empleado.Extension = Extension;
            empleado.Nota = notas; empleado.Reportes = reportes; empleado.DirecFoto = direcFoto;

            if (empleado.Actualizar() == true)
                Listar();
            Response.Write("<script>alert('" + empleado.Mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            string criterio = ddlCriterio.SelectedValue;
            gvEmpleado.DataSource = empleado.Buscar(texto, criterio).Tables[0];
            gvEmpleado.DataBind();
        }

    }
}