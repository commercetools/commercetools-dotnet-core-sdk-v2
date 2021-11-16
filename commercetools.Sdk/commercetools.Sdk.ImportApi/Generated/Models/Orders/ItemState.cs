using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class ItemState : IItemState
    {
        public double Quantity { get; set;}
        
        public IStateKeyReference State { get; set;}
    }
}
