using commercetools.Api.Models.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public partial class ProjectSetShippingRateInputTypeAction : IProjectSetShippingRateInputTypeAction
    {
        public string Action { get; set;}
        
        public IShippingRateInputType ShippingRateInputType { get; set;}
        public ProjectSetShippingRateInputTypeAction()
        { 
           this.Action = "setShippingRateInputType";
        }
    }
}
