using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISample.Dto
{
    public class LogInRequestDto
    {
        [Required]
        public string EmailOrPhone { get; set; }
        [Required]
        public string PIN { get; set; }
    }
}
