using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.ImportApi.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Products.SearchKeywords))]
    public partial interface ISearchKeywords : IDictionary<string, IList<ISearchKeyword>>
    {
    }
}
