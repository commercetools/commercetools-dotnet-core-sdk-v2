using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListUpdate))]
    public partial interface IMyShoppingListUpdate
    {
        long Version { get; set; }

        List<IMyShoppingListUpdateAction> Actions { get; set; }

    }
}
