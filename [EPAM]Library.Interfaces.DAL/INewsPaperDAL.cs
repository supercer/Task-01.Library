using _EPAM_Library.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EPAM_Library.Interfaces.DAL
{
    public interface INewsPaperDAL
    {
        IEnumerable<NewsPaperDTO> GetAll();
        NewsPaperDTO Get(int id);
        int Create(NewsPaperDTO topic);
        bool Delete(int id);
        bool Update(NewsPaperDTO topic);
    }
}
