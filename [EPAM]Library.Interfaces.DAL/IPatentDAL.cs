using _EPAM_Library.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EPAM_Library.Interfaces.DAL
{
   public interface IPatentDAL
    {
        IEnumerable<PatentDTO> GetAll();
        PatentDTO Get(int id);
        int Create(PatentDTO topic);
        bool Delete(int id);
        bool Update(PatentDTO topic);
    }
}
