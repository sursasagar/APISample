using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISample.Dto
{
    public class VehicleDetailDto
    {
        public Guid Id { get; set; }
        public string VIN { get; set; }
        public string ModelName { get; set; }
        public string ImageURL { get; set; }
        public string AliasName { get; set; }
        public string SMSVehicleId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
        public bool IsActive { get; set; }

        public int ThreasholdMillage { get; set; }

    }
}
