using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISample.Dto
{
    public class ServicesCheckInAddDto
    {
        [Required]
        public string SMSServiceId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string ServiceName { get; set; }

        [Required]
        public ServiceTypeEnum ServiceType { get; set; }

        public string? EditableServiceProblem { get; set; }
        public int? Duration { get; set; }
        public double? Cost { get; set; }
    }
}
