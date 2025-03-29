using Blazor_Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Models.Models
{
    public class Car : ICar
    {
        [Key]
        public int Id { get; set; }
        public required string Model { get; set; }
        public string? Brand { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

    }
}
