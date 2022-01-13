using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Products
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Products.SearchKeywords))]
    public interface ISearchKeywords : IDictionary<string, List<ISearchKeyword>>
    {
    }
}
