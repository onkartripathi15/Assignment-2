using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    class UserClass
    {
        [Key]
        public int Id { get; set; }
        public string source { get; set; }
        public string destination { get; set; }
    }
}
