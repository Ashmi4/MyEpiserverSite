using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.Web;

namespace MyEpiserverSite.Models.Pages
{
    public class ListImage
    {
        [Display(Name = "Label")]
        public virtual string Label { get; set; }

        [Display(Name = "Value")]
        public virtual string Value { get; set; }

        [Display(Name = "Image")]
        [UIHint(EPiServer.Web.UIHint.Image)]
        public virtual ContentReference Image { get; set; }
    }
}