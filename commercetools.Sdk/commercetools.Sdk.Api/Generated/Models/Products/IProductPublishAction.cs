using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductPublishAction))]
    public partial interface IProductPublishAction : IProductUpdateAction
    {
        IProductPublishScope Scope { get; set; }

    }
}
