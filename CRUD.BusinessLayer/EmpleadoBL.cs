using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CRUD.DataLayer;
using CRUD.EntityLayer;

namespace CRUD.BusinessLayer
{
    public class EmpleadoBL
    {
        PersonsDL personDL = new PersonsDL();

        public List<Empleado> Lista()
        {
            try
            {
                return personDL.Lista();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Empleado Obtener(int idEmpleado)
        {
            try
            {
                return personDL.Obtener(idEmpleado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}