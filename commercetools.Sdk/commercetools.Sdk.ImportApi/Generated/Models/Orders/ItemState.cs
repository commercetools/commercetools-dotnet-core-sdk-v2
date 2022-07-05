using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class ItemState : IItemState
    {
        public decimal Quantity { get; set; }

        public IStateKeyReference State { get; set; }
    }
}
