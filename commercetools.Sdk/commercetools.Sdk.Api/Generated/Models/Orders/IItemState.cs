using commercetools.Sdk.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.ItemState))]
    public partial interface IItemState
    {
        double Quantity { get; set; }

        IStateReference State { get; set; }
    }
}
