using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.ItemState))]
    public partial interface IItemState
    {
        long Quantity { get; set; }

        IStateKeyReference State { get; set; }

    }
}
