using System.ComponentModel.DataAnnotations;

namespace MyEpiserverSite.Models.Pages
{
    public class Location
    {
        
        [Display(Name = "Label")]
        public virtual string Label { get; set; }

        [Display(Name = "Value")]
        public virtual string Value { get; set; }
    }
}