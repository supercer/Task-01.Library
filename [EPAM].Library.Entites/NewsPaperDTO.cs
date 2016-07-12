using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EPAM_Library.Entites
{
   public class NewsPaperDTO
    {
        public int Id;

        public string Name { get; set; }

        public int Publisher { get; set; }

        public string PlaceOfPublication { get; set; }

        public int NewspaperPublishingId { get; set; }



    }
}
