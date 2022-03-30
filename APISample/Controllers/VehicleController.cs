using APISample.Dto;
using APISample.Response;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APISample.Controllers
{
    [Route("api/Customer/{customerId}/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        /// <summary>
        /// return list of vehicle for particular customer, 
        /// CustomerId will be retrive via token.
        /// </summary>
        /// <returns>Return list of vehicles</returns>
        [HttpGet]
        public List<VehicleDto> Get()
        {
            return new List<VehicleDto>();
        }

       /// <summary>
       /// get vehicle information , with mileage threshold limit
       /// </summary>
       /// <param name="id">VehicleId</param>
       /// <returns>Vehicle detail</returns>
        [HttpGet("{id}")]
        public VehicleDetailDto Get(Guid id)
        {
            return new VehicleDetailDto();
        }

        /// <summary>
        /// Add new vehicle
        /// </summary>
        /// <param name="vehicleAddDto"></param>
        /// <returns>Uniform response data , then redirect to vehicle list page </returns>
        [HttpPost]
        public ResponseData Post([FromBody] VehicleAddDto  vehicleAddDto)
        {
            return new ResponseData();
        }

        /// <summary>
        /// Update vehicle information only aliasName and millage.
        /// </summary>
        /// <param name="id">vehicleId</param>
        /// <param name="vehicleUpdateDto"></param>
        /// <returns>Uniform response data , then redirect to vehicle list page </returns>
        [HttpPut("{id}")]
        public ResponseData Put(Guid id, [FromBody] VehicleUpdateDto  vehicleUpdateDto)
        {
            return new ResponseData();
        }

        /// <summary>
        /// Deactivate vehicle on base of IsActive = false on record , condition : if service order is not active / processing
        /// </summary>
        /// <param name="id">VehicleId</param>
        /// <returns> Uniform response data , then redirect to vehicle list page </returns>
        [HttpDelete("{id}")]
        public ResponseData Delete(Guid id)
        {
            return new ResponseData();
        }


        

    }
}
