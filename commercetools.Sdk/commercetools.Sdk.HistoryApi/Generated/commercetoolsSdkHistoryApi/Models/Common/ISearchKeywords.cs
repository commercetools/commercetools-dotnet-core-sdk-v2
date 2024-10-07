using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.SearchKeywords))]
    public interface ISearchKeywords : IDictionary<string, IList<ISearchKeyword>>
    {
    }
}
