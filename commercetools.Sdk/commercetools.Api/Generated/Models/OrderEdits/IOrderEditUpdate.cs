using commercetools.Api.Generated.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.OrderEdits
{
    public interface IOrderEditUpdate 
    {
        long Version { get; set;}
        
        List<IOrderEditUpdateAction> Actions { get; set;}
        
        bool DryRun { get; set;}
    }
}
