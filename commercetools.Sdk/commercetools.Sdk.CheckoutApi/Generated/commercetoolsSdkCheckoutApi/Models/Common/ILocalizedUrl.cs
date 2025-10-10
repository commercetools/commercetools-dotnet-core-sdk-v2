using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.CheckoutApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Common.LocalizedUrl))]
    public partial interface ILocalizedUrl : IDictionary<string, string>
    {
    }
}
