using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _EPAM_Library.Entites;

namespace _EPAM_Library.Interfaces.DAL
{
    public interface INewsPaperPublishingDAL
    {
        IEnumerable<NewsPaperPublishingDTO> GetAll();
        NewsPaperPublishingDTO Get(int id);
        int Create(NewsPaperPublishingDTO topic);
        bool Delete(int id);
        bool Update(NewsPaperPublishingDTO topic);
    }
}
