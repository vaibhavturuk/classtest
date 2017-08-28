using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClassTestMVC.Models
{
    public class Emp
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = " Enter Name")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = " Enter Email")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = " Enter Phone ")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = " Marital Status")]
        public bool MaritalStatus { get; set; }

        [Display(Name = " State ")]
        public int StateId { get; set; }

        [Display(Name = "City ")]
        public int cityId { get; set; }

        public City City { get; set; }
      
    }
}