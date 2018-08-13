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
    public class BLUsuario : IBase<Usuario>
    {

        #region Interface Methods Implemented
        public void AddNew(Usuario oTemp)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    dbContext.dbUsuario.Add(oTemp);
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

        public void Edit(Usuario oTemp)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    Usuario Temp = new Usuario();

                    Temp = dbContext.dbUsuario.Where(c => c.IdUsuario == oTemp.IdUsuario).FirstOrDefault();

                    if(Temp==null)
                    {
                        throw new Exception("El registro que intenta modificar, no existe!");
                    }
                    else
                    {
                        Temp.NombreUsuario = oTemp.NombreUsuario;
                        Temp.CodigoUsuario = oTemp.CodigoUsuario;
                        Temp.IdRol = oTemp.IdRol;
                        dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Usuario> GetAll()
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    return dbContext.dbUsuario.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuario GetOne(int id)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    return dbContext.dbUsuario.Where(c => c.IdUsuario == id).FirstOrDefault();
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
