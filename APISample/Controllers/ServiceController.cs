using APISample.Dto;
using APISample.Response;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APISample.Controllers
{
    [Route("api/Customer/{customerId}/Vehicle/{vehicleId}/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {

        ///// <summary>
        ///// Give a list of available services via SMSClientAPI (Fetch list of services).
        ///// CustomerId Will be retrive by token.
        ///// </summary>
        ///// <param name="getVehicleServicesRequestDto">  ThresholdMillage : above | below vehilce millage  </param>
        ///// <returns>Return list of services with its types</returns>
        //[HttpGet]
        //[Route("api/[controller]/GetVehicleServices")]
        //public GetVehicleGroupSerivcesDto GetVehicleServices(GetVehicleServicesRequestDto  getVehicleServicesRequestDto)
        //{
        //    return new GetVehicleGroupSerivcesDto();
        //}

        // <summary>
        /// Give a list of available services via SMSClientAPI (Fetch list of services).
        /// CustomerId Will be retrive by token.
        /// </summary>
        /// <param name="getVehicleServicesRequestDto">  ThresholdMillage : above | below vehilce millage  </param>
        /// <returns>Return list of services with its types</returns>
        [HttpGet("{thresholdMileage}")]        
        public GetVehicleGroupSerivcesDto Get(string thresholdMileage)
        {
            return new GetVehicleGroupSerivcesDto();
        }


        /// <summary>
        /// Create new order services as Check-In status
        /// CustomerId will be retrived in token
        /// </summary>
        /// <param name="vehicleServicesCheckInDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Checkin")]
        public ResponseData Checkin([FromBody] CheckInServicesDto  checkInServicesDto)
        {
            return new ResponseData();
        }

        /// <summary>
        /// save new order services as Confirm status , then push all selected services to SMSClientAPI (Save the list of services user selected)
        /// CustomerId will be retrived in token
        /// </summary>
        /// <param name="confirmServiceRequestDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ConfirmService")]
        public ResponseData ConfirmService([FromBody] ConfirmServiceRequestDto  confirmServiceRequestDto)
        {
            return new ResponseData();
        }

        /// <summary>
        /// Save order services as Processing status.
        /// If acknowledged success by sms system,
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DropMyKeyOff")]
        public ResponseData DropMyKeyOff([FromBody] DropOffKeyRequestDto  dropOffKeyRequestDto)
        {
            return new ResponseData();
        }

        /// <summary>
        /// Shows all active order service list locally from our DB for current customer,
        /// CustomerId will be retrive by token
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetOrderServices/{orderId}")]
        public GetOrderServicesResponseDto GetOrderServices(Guid orderId)
        {
            return new GetOrderServicesResponseDto();
        }

    }
}
