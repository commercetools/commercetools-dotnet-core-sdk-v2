using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.TaxCategories
{
    [DeserializeAs(typeof(commercetools.Api.Models.TaxCategories.SubRate))]
    public partial interface ISubRate 
    {
        string Name { get; set;}
        
        double Amount { get; set;}
    }
}
