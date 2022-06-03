using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Candyshop.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [Required (ErrorMessage ="Please enter your first name")]
        [Display(Name ="Förnamn")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Efternamn")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [Display(Name = "Gatuadress")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter city")]
        [Display(Name = "Stad")]
        public string City { get; set; }

        //[Required(ErrorMessage = "Please enter your state")]
        //public string State { get; set; }

        [Required(ErrorMessage = "Please enter your zip")]
        [StringLength(5,MinimumLength = 5)]
        [Display(Name = "Postnr")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage ="Please enter your phone")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefonnummer")]
        public string PhoneNumber { get; set; }
        public string Customer => FirstName + " " + LastName;
        public  List<OrderDetail> OrderDetails { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }

    }
}
