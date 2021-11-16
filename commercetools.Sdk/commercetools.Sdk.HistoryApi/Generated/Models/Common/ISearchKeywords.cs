using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.SearchKeywords))]
    public interface ISearchKeywords : IDictionary<string, List<ISearchKeyword>>
    {
    }
}
