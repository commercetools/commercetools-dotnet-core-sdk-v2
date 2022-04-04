using commercetools.Sdk.Api.Models.States;


namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class ItemState : IItemState
    {
        public double Quantity { get; set; }

        public IStateReference State { get; set; }
    }
}
