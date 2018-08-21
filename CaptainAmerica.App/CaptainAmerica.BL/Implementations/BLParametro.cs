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
    public class BLParametro : IBase<Parametro>
    {

        #region Interface Methods Implemented
        public void AddNew(Parametro oTemp)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    dbContext.dbParametro.Add(oTemp);
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

        public void Edit(Parametro oTemp)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    Parametro Temp = new Parametro();

                    Temp = dbContext.dbParametro.Where(c => c.IdParametro == oTemp.IdParametro).FirstOrDefault();

                    if(Temp==null)
                    {
                        throw new Exception("El registro que intenta modificar, no existe!");
                    }
                    else
                    {
                        Temp.Nombre = oTemp.Nombre;
                        Temp.Valor = oTemp.Valor;
                        dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Parametro> GetAll()
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    return dbContext.dbParametro.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Parametro GetOne(int id)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    return dbContext.dbParametro.Where(c => c.IdParametro == id).FirstOrDefault();
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
