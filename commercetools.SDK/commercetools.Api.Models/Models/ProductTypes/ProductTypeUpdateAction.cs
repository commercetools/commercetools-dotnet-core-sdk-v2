using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [Discriminator(nameof(Action))]
    public abstract partial class ProductTypeUpdateAction 
    {
        public string Action { get; set;}
    }
}
