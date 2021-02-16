using commercetools.Ml.Models.ImageSearchConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.ImageSearchConfigs
{
    public partial class ChangeStatusUpdateAction : IChangeStatusUpdateAction
    {
        public string Action { get; set;}
        
        public IImageSearchConfigStatus Status { get; set;}
        public ChangeStatusUpdateAction()
        { 
           this.Action = "changeStatus";
        }
    }
}
