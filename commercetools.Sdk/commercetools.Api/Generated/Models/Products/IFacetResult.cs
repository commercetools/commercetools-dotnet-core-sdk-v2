using commercetools.Api.Generated.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IFacetResult 
    {
        string Type { get; set;}
        
        FacetTypes TypeAsEnum { get; }
    }
}
