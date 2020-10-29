using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.PriceTierDraft))]
    public interface IPriceTierDraft 
    {
        long MinimumQuantity { get; set;}
        
        IMoney Value { get; set;}
    }
}
