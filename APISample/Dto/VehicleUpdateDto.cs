using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISample.Dto
{
    public class VehicleUpdateDto
    {
        [Required]
        public Guid Id { get; set; }


        [DataType(DataType.Text)]
        public string AliasName { get; set; }

        public long Millage { get; set; }



    }
}
