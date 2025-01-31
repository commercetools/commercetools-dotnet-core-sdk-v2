using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.LocalizedString))]
    public partial interface ILocalizedString : IDictionary<string, string>
    {
    }
}
