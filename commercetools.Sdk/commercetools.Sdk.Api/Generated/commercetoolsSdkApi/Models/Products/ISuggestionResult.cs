using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.SuggestionResult))]
    public partial interface ISuggestionResult : IDictionary<string, IList<ISuggestion>>
    {
    }
}
