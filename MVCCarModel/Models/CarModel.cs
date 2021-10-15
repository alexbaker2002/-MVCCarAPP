using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MVCCarModel.Models
{
    public class CarModel
    {


        public int Id { get; set; } // primary key for database ** required 
        public string UserId { get; set; } // Foreign Key for database - using to link to others  ** must exsist

        [Required]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [Display(Name = "Make of Vehicle")]
        public string VehicleMake { get; set; }


        [Required]
        [StringLength(15, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [Display(Name = "Model of Vehicle")]
        public string VehicleModel { get; set; }


       
        [Required]
        [Display(Name = "Year of Vehicle")]
        public int VehicleYear { get; set; }
        [Display(Name = "Vehicle Mileage")]
        public int VehicleMilage { get; set; }
        [Display(Name = "Vehicle Price")]
        public decimal VehiclePrice { get; set; }
        [Display(Name = "Vehicle Condition")]
        public bool VehicleIsNew { get; set; } = false;

        public DateTime EntryCreated { get; set; }
       
        public virtual UserModel User { get; set; } // navigational property.. this tells the database that this contact is only connected to one user... every contact will only belong to one User

        [NotMapped]
        [DataType(DataType.Upload)]
        [Display(Name = "Contact Image")]
        public IFormFile ImageFile { get; set; } // file on computer 
        public byte[] ImageData { get; set; } // file split up into bytes and added into an array // byte[] ImageData
        public string ImageType { get; set; } // store the image type so it can be rendered 
    }
}
