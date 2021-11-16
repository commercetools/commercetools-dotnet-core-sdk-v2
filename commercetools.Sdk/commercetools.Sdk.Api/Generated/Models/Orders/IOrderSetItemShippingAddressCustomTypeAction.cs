using commercetools.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetItemShippingAddressCustomTypeAction))]
    public partial interface IOrderSetItemShippingAddressCustomTypeAction : IOrderUpdateAction
    {
        string AddressKey { get; set;}
        
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
