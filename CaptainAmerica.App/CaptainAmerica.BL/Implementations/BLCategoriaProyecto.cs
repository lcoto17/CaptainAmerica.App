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
    public class BLCategoriaProyecto : IBase<ProyectoCategoria>
    {
        #region Interface Methods Implemented
        public void AddNew(ProyectoCategoria oTemp)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    dbContext.dbProyectoCategoria.Add(oTemp);
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

        public void Edit(ProyectoCategoria oTemp)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    ProyectoCategoria Temp = new ProyectoCategoria();

                    Temp = dbContext.dbProyectoCategoria.Where(c => c.IdCategoriaProyecto == oTemp.IdCategoriaProyecto).FirstOrDefault();

                    if (Temp == null)
                    {
                        throw new Exception("El registro que intenta modificar, no existe!");
                    }
                    else
                    {
                        Temp.NombreCategoriaProyecto = oTemp.NombreCategoriaProyecto;
                        Temp.DescrCategoriaProyecto = oTemp.DescrCategoriaProyecto;
                        dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ProyectoCategoria> GetAll()
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    return dbContext.dbProyectoCategoria.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ProyectoCategoria GetOne(int id)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    return dbContext.dbProyectoCategoria.Where(c => c.IdCategoriaProyecto == id).FirstOrDefault();
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
