using FakturaTest.Domains.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakturaTest.Service.DTOs
{
    public class AddCarDto
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public Color Color { get; set; }
    }
}
