using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Models.Models
{
    public class NewModel1
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty; 
        public string Type { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;  
        public bool IsActive { get; set; }
        

    }
}
