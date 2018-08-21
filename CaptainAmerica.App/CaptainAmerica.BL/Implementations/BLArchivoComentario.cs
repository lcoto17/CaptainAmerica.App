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
    public class BLArchivoComentario : IBase<ArchivoComentario>
    {

        #region Interface Methods Implemented
        public void AddNew(ArchivoComentario oTemp)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    dbContext.dbArchivoComentario.Add(oTemp);
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

        public void Edit(ArchivoComentario oTemp)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    ArchivoComentario Temp = new ArchivoComentario();

                    Temp = dbContext.dbArchivoComentario.Where(c => c.IdArchivoComentario == oTemp.IdArchivoComentario).FirstOrDefault();

                    if(Temp==null)
                    {
                        throw new Exception("El registro que intenta modificar, no existe!");
                    }
                    else
                    {
                        Temp.ArchivoComentarioDescr = oTemp.ArchivoComentarioDescr;
                        dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ArchivoComentario> GetAll()
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {

                    return dbContext.dbArchivoComentario.Include("Usuario").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ArchivoComentario GetOne(int id)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    return dbContext.dbArchivoComentario.Where(c => c.IdArchivoComentario == id).FirstOrDefault();
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
