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

    public partial class FacetResults : Dictionary<string, IFacetResult>, IFacetResults
    {
    }
}
