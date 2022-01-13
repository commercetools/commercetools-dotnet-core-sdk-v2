using commercetools.Api.Models.States;


namespace commercetools.Api.Models.Orders
{
    public partial class ItemState : IItemState
    {
        public double Quantity { get; set; }

        public IStateReference State { get; set; }
    }
}
