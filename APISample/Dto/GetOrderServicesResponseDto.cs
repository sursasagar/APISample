using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISample.Dto
{
    public class GetOrderServicesResponseDto
    {
        public Guid VehicleId { get; set; }
        public VehicleDto VehicleDto { get; set; }

        public Guid ServiceOrderId { get; set; }
        public ServiceOrderDto ServiceOrder { get; set; }

        public List<ServiceOrderDetailDto>  ServiceOrderDetails { get; set; }

    }
}
