using commercetools.Sdk.ImportApi.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Products
{

    public partial class SearchKeywords : Dictionary<string, IList<ISearchKeyword>>, ISearchKeywords
    {
    }
}
