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
    public class BLCliente : IBase<Cliente>
    {
        #region Interface Methods Implemented
        public void AddNew(Cliente oTemp)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    dbContext.dbCliente.Add(oTemp);
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

        public void Edit(Cliente oTemp)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    Cliente Temp = new Cliente();

                    Temp = dbContext.dbCliente.Where(c => c.IdCliente == oTemp.IdCliente).FirstOrDefault();

                    if (Temp == null)
                    {
                        throw new Exception("El registro que intenta modificar, no existe!");
                    }
                    else
                    {
                        Temp.NombreCliente = oTemp.NombreCliente;
                        dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Cliente> GetAll()
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    return dbContext.dbCliente.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Cliente GetOne(int id)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    return dbContext.dbCliente.Where(c => c.IdCliente == id).FirstOrDefault();
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
