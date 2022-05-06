using FakturaTest.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakturaTest.Service.DTOs
{
    public class ViewCarDto
    {
        public IEnumerable<Car> Cars { get; set; }
    }
}
