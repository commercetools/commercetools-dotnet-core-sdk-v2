using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.CategoryOrderHints))]
    public partial interface ICategoryOrderHints : IDictionary<string, string>
    {
    }
}
