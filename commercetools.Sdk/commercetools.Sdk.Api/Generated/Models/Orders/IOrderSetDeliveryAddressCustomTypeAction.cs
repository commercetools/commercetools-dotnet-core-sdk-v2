using commercetools.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetDeliveryAddressCustomTypeAction))]
    public partial interface IOrderSetDeliveryAddressCustomTypeAction : IOrderUpdateAction
    {
        string DeliveryId { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }
    }
}
