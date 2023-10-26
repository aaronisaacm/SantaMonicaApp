using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaMonicaApp.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Extensions { get; set; } = string.Empty;
        public string Cards { get; set; } = string.Empty;
        public bool Active { get; set; } = true;
    }
}
