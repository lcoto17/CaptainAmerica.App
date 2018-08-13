using CaptainAmerica.BL.Interfaces;
using CaptainAmerica.Data;
using CaptainAmerica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaptainAmerica.BL.Implementations
{
    public class BLProyectoMiembro : IBase<ProyectoMiembro>
    {

        #region Interface Methods Implemented
        public void AddNew(ProyectoMiembro oTemp)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    dbContext.dbProyectoMiembro.Add(oTemp);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ProyectoMiembro oTemp)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    ProyectoMiembro Temp = new ProyectoMiembro();

                    Temp = dbContext.dbProyectoMiembro.Where(c => c.IdProyectoMiembro == oTemp.IdProyectoMiembro).FirstOrDefault();

                    if(Temp==null)
                    {
                        throw new Exception("El registro que intenta modificar, no existe!");
                    }
                    else
                    {
                        Temp.IdProyecto = oTemp.IdProyecto;
                        Temp.IdUsuario = oTemp.IdUsuario;
                        Temp.MiembroPermiso = oTemp.MiembroPermiso;
                        dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ProyectoMiembro> GetAll()
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    return dbContext.dbProyectoMiembro.Include("Usuario").Include("Proyecto").Include("Proyecto.Cliente").Include("Proyecto.ProyectoCategoria").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ProyectoMiembro GetOne(int id)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    return dbContext.dbProyectoMiembro.Where(c => c.IdProyectoMiembro == id).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

    }
}
