using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISample.Dto
{
    public class GetVehicleGroupSerivcesDto
    {
        
        public Guid VehicleId { get; set; }
        public VehicleDto  VehicleDto { get; set; }

        public List<VehicleSerivceGroupDto>  VehicleSerivceGroups { get; set; }

    }

    public class VehicleSerivceGroupDto
    {
        public string SMSGroupId { get; set; }
        public string GroupName { get; set; }
        public string ImageURL { get; set; }
        public ServiceTypeEnum ServiceType { get; set; }
        public int? TotalDuration { get; set; }
        public double? TotalCost { get; set; }
        public int DisplayOrderNumber { get; set; }

        public List<VehicleSerivceDto>  VehicleSerivces { get; set; }
    }

    public class VehicleSerivceDto
    {
        public string SMSGroupId { get; set; }

        public string SMSServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ImageURL { get; set; }
        public int? Duration { get; set; }
        public double? Cost { get; set; }
        public int DisplayOrderNumber { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

    }
}
