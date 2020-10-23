using commercetools.Api.Generated.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Common
{
    public interface IPriceTierDraft 
    {
        long MinimumQuantity { get; set;}
        
        IMoney Value { get; set;}
    }
}
