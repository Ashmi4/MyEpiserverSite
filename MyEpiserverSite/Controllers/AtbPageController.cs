using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using MyEpiserverSite.Models.Pages;
using System;
using MyEpiserverSite.Models.ViewModels;
namespace MyEpiserverSite.Controllers
{
    public class AtbPageController : PageController<AtbPage>
    {
        public ActionResult Index(AtbPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);
            return View(model);
            
        }
        private static IPageViewModel<SitePageData> CreateModel(SitePageData page)
        {
            var type = typeof(PageViewModel<>).MakeGenericType(page.GetOriginalType());
            return Activator.CreateInstance(type, page) as IPageViewModel<SitePageData>;
        }
    }
}