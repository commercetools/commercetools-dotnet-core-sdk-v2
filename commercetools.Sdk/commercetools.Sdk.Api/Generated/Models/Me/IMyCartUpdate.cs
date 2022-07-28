using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartUpdate))]
    public partial interface IMyCartUpdate
    {
        long Version { get; set; }

        List<IMyCartUpdateAction> Actions { get; set; }

    }
}
