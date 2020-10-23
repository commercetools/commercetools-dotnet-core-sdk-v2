using commercetools.Api.Generated.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Carts
{
    public interface ITaxPortionDraft 
    {
        string Name { get; set;}
        
        double Rate { get; set;}
        
        IMoney Amount { get; set;}
    }
}
