using commercetools.Sdk.Api.Models.States;


namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class ItemState : IItemState
    {
        public decimal Quantity { get; set; }

        public IStateReference State { get; set; }
    }
}
