using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.LocalizedString))]
    public interface ILocalizedString : IDictionary<string, string>
    {
    }
}
