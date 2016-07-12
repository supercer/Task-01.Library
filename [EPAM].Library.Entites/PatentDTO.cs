using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EPAM_Library.Entites
{
   public class PatentDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Author[] Authors { get; set; }

        public string Country { get; set; }

        public string RegistrationNumber { get; set; }

        DateTime ApplicationDate { get; set; }

        public uint NumberOfPages { get; set; }

        public string Notation { get; set; }

    }
}
