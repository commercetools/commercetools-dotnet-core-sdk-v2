using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerUpdate))]
    public partial interface IMyCustomerUpdate
    {
        long Version { get; set; }

        List<IMyCustomerUpdateAction> Actions { get; set; }

    }
}
