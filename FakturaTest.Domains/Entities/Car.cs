using FakturaTest.Domains.Commons;
using FakturaTest.Domains.Enums;

namespace FakturaTest.Domains.Entities
{
    public class Car : Auditable
    {
        public string Model { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Color Color { get; set; }
    }
}
