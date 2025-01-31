using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.SearchKeywords))]
    public partial interface ISearchKeywords : IDictionary<string, IList<ISearchKeyword>>
    {
    }
}
