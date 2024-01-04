using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PeCe_sProductosTecnologicos.Ticket  
{
    public partial class AgregarTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarPersonaEmpresa();
            }
        }

        protected void btnAgregarPelicula_Click(object sender, EventArgs e)
        {
            Modelo.Ticket p = new Modelo.Ticket()
            {
                Nombre = txtNombre.Text,
                Rut = txtRut.Text,
                Telefono = txtTelefono.Text,
                Email = txtNombre.Text,
                PersonaEmpresa = ddlPersonaEmpresa.SelectedItem.Text,
                SoporteTecnico = ckbSoporteTecnico.Checked,
                Reparacion = ckbEnReparacion.Checked,
                Devolucion = ckbDevolucion.Checked,
                Descripcion = txtDescripcion.Text
            };

            string message = TicketControlador.Create(p);

            string url = string.Format("~/ListarTodos.aspx?message={0}", message);

            Response.Redirect(url);
        }

        private void CargarPersonaEmpresa()
        {
            ddlPersonaEmpresa.Items.Clear();

            ddlPersonaEmpresa.Items.Add("Seleccionar");
            ddlPersonaEmpresa.Items[0].Attributes["disabled"] = "disabled";
            ddlPersonaEmpresa.Items[0].Attributes["selected"] = "selected";

            var PersonaEmpresa = System.Enum.GetValues(typeof(PersonaEmpresa));

            foreach (var PersonaEmpresa in PersonaEmpresa)
            {
                ddlPersonaEmpresa.Items.Add(PersonaEmpresa.ToString());
            }

            ddlPersonaEmpresa.DataBind();
        }

        
        
        private void SetDefaultValueDDl(DropDownList ddl)
        {
            ddl.Items.Clear();

            ddl.Items.Add("Seleccionar");
            ddl.Items[0].Attributes["disabled"] = "disabled";
            ddl.Items[0].Attributes["selected"] = "selected";
        }
    }

}




