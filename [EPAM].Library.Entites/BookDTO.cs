using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EPAM_Library.Entites
{
    public class BookDTO : LibraryObjectDTO
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public Author[] Authors { get; set; }

        public string PlaceOfPublication { get; set; }

        public string PublishingHouse { get; set; }

        public DateTime TheYearOfPublishing { get; set; }

        public uint NumberOfPages { get; set; }

        public string Notation { get; set; }

        public string ISBN { get; set; }
    }
}
