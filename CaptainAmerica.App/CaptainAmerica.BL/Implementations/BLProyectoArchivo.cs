using CaptainAmerica.BL.Interfaces;
using CaptainAmerica.Data;
using CaptainAmerica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CaptainAmerica.BL.Implementations
{
    public class BLProyectoArchivo : IBase<ProyectoArchivo>
    {

        #region Interface Methods Implemented
        public void AddNew(ProyectoArchivo oTemp)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    dbContext.dbProyectoArchivo.Add(oTemp);
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

        public void Edit(ProyectoArchivo oTemp)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    ProyectoArchivo Temp = new ProyectoArchivo();

                    Temp = dbContext.dbProyectoArchivo.Where(c => c.IdProyectoArchivo == oTemp.IdProyectoArchivo).FirstOrDefault();

                    if(Temp==null)
                    {
                        throw new Exception("El registro que intenta modificar, no existe!");
                    }
                    else
                    {
                        Temp.NombreArchivo = oTemp.NombreArchivo;
                        Temp.URLGuardado = oTemp.URLGuardado;
                        dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ProyectoArchivo> GetAll()
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {

                    return dbContext.dbProyectoArchivo.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ProyectoArchivo GetOne(int id)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    return dbContext.dbProyectoArchivo.Where(c => c.IdProyectoArchivo == id).FirstOrDefault();
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
