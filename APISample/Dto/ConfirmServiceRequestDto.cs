using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISample.Dto
{
    public class ConfirmServiceRequestDto
    {
        [Required]
        public Guid OrderServiceId { get; set; }

       
        public List<ServicesRecommendationAddDto>  servicesRecommendationAddDtos { get; set; } = new List<ServicesRecommendationAddDto>();

    }
}
