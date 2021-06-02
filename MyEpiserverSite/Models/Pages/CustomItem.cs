using System.ComponentModel.DataAnnotations;

namespace Site.Models.Pages
{
    public class Location
    {
        [Display(Name = "Address line 1")]
        public virtual string AddressLine1 { get; set; }

        [Display(Name = "Address line 2")]
        public virtual string AddressLine2 { get; set; }

        public virtual string City { get; set; }

        public virtual string Country { get; set; }
    }
}