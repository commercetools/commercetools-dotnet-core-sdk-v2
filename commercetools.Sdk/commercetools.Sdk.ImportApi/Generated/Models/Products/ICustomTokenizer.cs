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
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Products.CustomTokenizer))]
    public partial interface ICustomTokenizer : ISuggestTokenizer
    {
        IList<string> Inputs { get; set; }
        IEnumerable<string> InputsEnumerable { set => Inputs = value.ToList(); }


    }
}
