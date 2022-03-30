using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISample.Dto
{
    public class VehicleAddDto
    {
        public string VIN { get; set; }

        public Guid CustomerId { get; set; }

        public IFormFile Image { get; set; }
        
        public string MakeYear { get; set; }

        public string ModelName { get; set; }

    }
}
