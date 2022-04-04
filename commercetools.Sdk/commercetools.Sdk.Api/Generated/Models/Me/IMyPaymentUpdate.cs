using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyPaymentUpdate))]
    public partial interface IMyPaymentUpdate
    {
        long Version { get; set; }

        List<IMyPaymentUpdateAction> Actions { get; set; }
    }
}
