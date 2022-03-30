using APISample.Dto;
using APISample.Response;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APISample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        /// <summary>
        ///  Check Customer on SMSClientAPI(Fetch user details) before login locally,
        ///  IF customer found on requested Client API,
        ///  Check if customer record found locally, if yes implement changes on customer attributes else Add new customer in our DB.
        ///  ELSE Register new customer in our system via redirecting to register page
        /// </summary>
        /// <param name="checkCustomerRequestDto"></param>
        /// <returns>redirect to login page if customer found else redirect to register page</returns>
        [HttpPost("CheckCustomer")]
        public ResponseData CheckCustomer([FromBody] CheckCustomerRequestDto checkCustomerRequestDto)
        {
            return new ResponseData();
        }

        ///// <summary>
        ///// Login customer via locally, this should call after checking customer from SMSSystem
        ///// </summary>
        ///// <param name="logInRequestDto"></param>
        ///// <returns></returns>
        //[HttpPost("Login")]
        //[Obsolete]       
        //public ResponseData Login([FromBody] LogInRequestDto  logInRequestDto)
        //{
        //    return new ResponseData();
        //}

        /// <summary>
        /// Load profile after successfully login,
        /// CustomerId will be retrive by token
        /// </summary>        
        /// <returns>Customer Detail for profile / homepage</returns>
        [HttpGet("{id}")]
        public CustomerDetailDto Get(Guid id)
        {
            return new CustomerDetailDto();
        }


        /// <summary>
        /// Register new customer locally and then call SMSClientAPI (Create new user) to create new cutomer on their SMSsystem
        /// </summary>
        /// <param name="customerAddDto"></param>
        /// <returns></returns>
        [HttpPost]
        public ResponseData Post([FromBody] CustomerAddDto  customerAddDto)
        {
            return new ResponseData();
        }

        

    }
}
