using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISample.Dto
{
    public class GetVehicleServicesRequestDto
    {
        public Guid VehicleId { get; set; }        
        public string ThresholdMillage { get; set; }
    }
}
