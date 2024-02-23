using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListUpdate))]
    public partial interface IMyShoppingListUpdate
    {
        long Version { get; set; }

        IList<IMyShoppingListUpdateAction> Actions { get; set; }
        IEnumerable<IMyShoppingListUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
