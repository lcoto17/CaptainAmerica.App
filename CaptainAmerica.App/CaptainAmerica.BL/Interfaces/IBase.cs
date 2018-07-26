using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaptainAmerica.Model;

namespace CaptainAmerica.BL.Interfaces
{
    public interface IBase<BaseModel> where BaseModel : Base
    {
        List<BaseModel> GetAll();
        BaseModel GetOne(int id);
        void AddNew(BaseModel oTemp);
        void Edit(BaseModel oTemp);
        void Delete(int id);

    }
}
