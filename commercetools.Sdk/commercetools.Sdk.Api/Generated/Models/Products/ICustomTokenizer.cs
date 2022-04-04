using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.CustomTokenizer))]
    public partial interface ICustomTokenizer : ISuggestTokenizer
    {
        List<string> Inputs { get; set; }
    }
}
