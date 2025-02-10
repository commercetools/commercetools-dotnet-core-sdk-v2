using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.LocalizedString))]
    public partial interface ILocalizedString : IDictionary<string, string>
    {
    }
}
