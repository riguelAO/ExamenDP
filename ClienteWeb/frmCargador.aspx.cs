using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class frmCargador : System.Web.UI.Page
    {
        private Cargador cargador= new Cargador();
        private void Listar()
        {
            gvCargador.DataSource = cargador.Listar().Tables[0];
            gvCargador.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text.Trim());
            string NombreCom = txtNombreCom.Text.Trim();
            string Celular = txtCelular.Text.Trim();

            cargador.Id = id; cargador.NombreCompa1 = NombreCom; cargador.Celular = Celular;
            if (cargador.Agregar() == true)
                Listar();
            Response.Write("<script>alert('" + cargador.Mensaje + "');</script>");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text.Trim());
            cargador.Id = id;
            if (cargador.Eliminar() == true)
                Listar();
            Response.Write("<script>alert('" + cargador.Mensaje + "');</script>");
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text.Trim());
            string NombreCom = txtNombreCom.Text.Trim();
            string Celular = txtCelular.Text.Trim();

            cargador.Id = id; cargador.NombreCompa1 = NombreCom; cargador.Celular = Celular;

            if (cargador.Actualizar() == true)
                Listar();
            Response.Write("<script>alert('" + cargador.Mensaje + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            string criterio = ddlCriterio.SelectedValue;
            gvCargador.DataSource = cargador.Buscar(texto, criterio).Tables[0];
            gvCargador.DataBind();
        }
    }
}