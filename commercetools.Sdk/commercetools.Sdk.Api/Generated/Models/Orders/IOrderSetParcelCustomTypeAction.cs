using commercetools.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetParcelCustomTypeAction))]
    public partial interface IOrderSetParcelCustomTypeAction : IOrderUpdateAction
    {
        string ParcelId { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }
    }
}
