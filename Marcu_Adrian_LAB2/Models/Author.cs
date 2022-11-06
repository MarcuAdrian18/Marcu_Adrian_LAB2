using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Marcu_Adrian_LAB2.Models
{
    public class Author
    {
        
        public string ID { get; set; }
        public string FirstName { get; set; }
        
        public decimal LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }


    }
}
