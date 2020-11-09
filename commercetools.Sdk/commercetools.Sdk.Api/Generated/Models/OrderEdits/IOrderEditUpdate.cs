using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditUpdate))]
    public partial interface IOrderEditUpdate 
    {
        long Version { get; set;}
        
        List<IOrderEditUpdateAction> Actions { get; set;}
        
        bool? DryRun { get; set;}
    }
}
