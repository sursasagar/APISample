using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISample.Dto
{
    public class CustomerAddDto
    {
        [Required]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string MobileNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        
        [DataType(DataType.Text)]
        public string VIN { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string VehicleModelName { get; set; }

        public IFormFile  VehicleImage { get; set; }

    }
}
