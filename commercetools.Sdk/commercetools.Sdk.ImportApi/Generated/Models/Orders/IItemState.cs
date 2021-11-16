using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.ItemState))]
    public partial interface IItemState 
    {
        double Quantity { get; set;}
        
        IStateKeyReference State { get; set;}
    }
}
