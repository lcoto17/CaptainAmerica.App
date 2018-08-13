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
    public class BLProyecto : IBase<Proyecto>
    {

        #region Interface Methods Implemented
        public void AddNew(Proyecto oTemp)
        {
            try
            {
                BLProyectoMiembro otempPM = new BLProyectoMiembro();
                BLUsuario oTempU = new BLUsuario();
                ProyectoMiembro opromie = new ProyectoMiembro();

                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    dbContext.dbProyecto.Add(oTemp);
                    dbContext.SaveChanges();

                    opromie.IdProyecto = oTemp.IdProyecto;
                    opromie.IdUsuario = oTempU.GetAll().Where(c => c.CodigoUsuario.ToLower() == WindowsIdentity.GetCurrent().Name.ToLower()).FirstOrDefault().IdUsuario;
                    opromie.MiembroPermiso = "F";


                    otempPM.AddNew(opromie);
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

        public void Edit(Proyecto oTemp)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    Proyecto Temp = new Proyecto();

                    Temp = dbContext.dbProyecto.Where(c => c.IdProyecto == oTemp.IdProyecto).FirstOrDefault();

                    if(Temp==null)
                    {
                        throw new Exception("El registro que intenta modificar, no existe!");
                    }
                    else
                    {
                        Temp.NombreProyecto = oTemp.NombreProyecto;
                        Temp.IdCategoriaProyecto = oTemp.IdCategoriaProyecto;
                        Temp.IdCliente = oTemp.IdCliente;
                        dbContext.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Proyecto> GetAll()
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    BLProyectoMiembro pm = new BLProyectoMiembro();
                    var temp = pm.GetAll()
                        .Where(c => c.Usuario.CodigoUsuario.ToLower() == WindowsIdentity.GetCurrent().Name.ToLower())
                        .Select(c => c.IdProyecto).ToList();

                    return dbContext.dbProyecto.Include("Cliente").Include("ProyectoCategoria").
                        Where(c=> temp.Contains(c.IdProyecto)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Proyecto GetOne(int id)
        {
            try
            {
                using (JJ_CPD dbContext = new JJ_CPD())
                {
                    return dbContext.dbProyecto.Include("Cliente").Include("ProyectoCategoria").Where(c => c.IdProyecto == id).FirstOrDefault();
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
