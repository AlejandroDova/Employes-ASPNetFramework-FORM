using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUD.EntityLayer;
using CRUD.BusinessLayer;
using System.Collections;
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

        public void Filtro(object sender, EventArgs e)
        {

            if ( !filtroIDtxt.Text.Equals("") )
            {
                if (!filtroIDtxt.Text.Equals("0"))
                {
                    int empleadoid = 0;
                    try
                    {
                        empleadoid = Convert.ToInt32(filtroIDtxt.Text);
                        List<Empleado> lista = empleadoBL.Filtro(empleadoid);

                        GVEmpleado.DataSource = lista;
                        GVEmpleado.DataBind();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }else
                {
                    MostrarEmpleados();
                }
                
            }
        }
    }
}