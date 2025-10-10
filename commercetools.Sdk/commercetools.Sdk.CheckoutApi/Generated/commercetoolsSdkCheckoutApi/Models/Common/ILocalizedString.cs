using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.CheckoutApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Common.LocalizedString))]
    public partial interface ILocalizedString : IDictionary<string, string>
    {
    }
}
