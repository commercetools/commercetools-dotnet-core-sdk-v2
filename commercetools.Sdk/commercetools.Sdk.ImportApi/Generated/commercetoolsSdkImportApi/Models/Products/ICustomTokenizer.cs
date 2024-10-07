using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
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
