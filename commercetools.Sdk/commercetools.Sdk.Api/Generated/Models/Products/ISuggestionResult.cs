using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.SuggestionResult))]
    public interface ISuggestionResult : IDictionary<string, List<ISuggestion>>
    {
    }
}
