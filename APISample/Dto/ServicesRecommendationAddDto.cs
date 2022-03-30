using System.ComponentModel.DataAnnotations;

namespace APISample.Dto
{
    public class ServicesRecommendationAddDto
    {       
        [Required]
        public string SMSServiceId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string ServiceName { get; set; }

        [Required]       
        public int Duration { get; set; }

        [Required]
        public double Cost { get; set; }
    }
}
