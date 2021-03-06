using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.Money))]
    public partial interface IMoney 
    {
        long CentAmount { get; set;}
        
        string CurrencyCode { get; set;}
    }
}
