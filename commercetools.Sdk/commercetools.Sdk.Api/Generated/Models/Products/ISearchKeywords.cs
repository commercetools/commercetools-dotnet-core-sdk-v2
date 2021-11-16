using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.SearchKeywords))]
    public interface ISearchKeywords : IDictionary<string, List<ISearchKeyword>>
    {
    }
}
