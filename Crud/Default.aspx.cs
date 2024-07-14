using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUD.EntityLayer;
using CRUD.BusinessLayer;
namespace Crud
{
    public partial class _Default : Page
    {
        EmpleadoBL empleadoBL = new EmpleadoBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        private void MostrarEmpleados()
        {
            List<Empleado> lista = empleadoBL.Lista();

            GVEmpleado.DataSource = lista;
            GVEmpleado.DataBind();
        }
    }
}