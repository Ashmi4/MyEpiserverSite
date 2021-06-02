using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.PlugIn;
using EPiServer.Core;

namespace MyEpiserverSite.Models.Pages
{
    
        [PropertyDefinitionTypePlugIn]
        public class LocationsProperty : PropertyList<Location> { }
    
}