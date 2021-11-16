using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.Attribute))]
    public partial interface IAttribute 
    {
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
