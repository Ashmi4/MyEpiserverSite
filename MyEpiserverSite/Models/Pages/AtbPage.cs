using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Find.Blocks.Models;
using MyEpiserverSite.Business.Rendering;
using System.ComponentModel.DataAnnotations;
using EPiServer.Cms.Shell.UI.ObjectEditing.EditorDescriptors;
using EPiServer.Shell.ObjectEditing;


namespace MyEpiserverSite.Models.Pages
{
    [ContentType(DisplayName = "AtbPage", GUID = "85def3d0-a00d-415e-bb09-25f5f2f45cfb", Description = "ATB Rocks!!!")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-article.png")]
    public class AtbPage : SitePageData, IContainerPage
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "The Page Heading",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual XhtmlString Heading { get; set; }        

        [CultureSpecific]
        [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
                   Name = "Description",
                   Description = "Description",
                   GroupName = SystemTabNames.Content,
                   Order = 2)]
        public virtual XhtmlString MainData { get; set; }

        [UIHint(EPiServer.Web.UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [CultureSpecific]
        [Display(
                   Name = "List",
                   Description = "List",
                   GroupName = SystemTabNames.Content,
                   Order = 3)]
        
        [EditorDescriptor(EditorDescriptorType = typeof(CollectionEditorDescriptor<Location>))]
        public virtual IList<Location> Locations { get; set; }

        [CultureSpecific]
        [Display(
                   Name = "ListImage",
                   Description = "ListImage",
                   GroupName = SystemTabNames.Content,
                   Order = 3)]

        [EditorDescriptor(EditorDescriptorType = typeof(CollectionEditorDescriptor<ListImage>))]
        public virtual IList<ListImage> ListImage { get; set; }

    }


}