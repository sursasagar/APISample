using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISample.Dto
{
    public class CheckInServicesDto
    {
        [Required]
        public Guid VehicleId { get; set; }

        [Required]
        public List<ServicesCheckInAddDto>   ServicesCheckInAddDtos { get; set; }
    }
}
