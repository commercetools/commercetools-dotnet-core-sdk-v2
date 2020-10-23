using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public abstract partial class ProductTypeUpdateAction : IProductTypeUpdateAction
    {
        public string Action { get; set;}
    }
}
