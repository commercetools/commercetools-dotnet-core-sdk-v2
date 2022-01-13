using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartRemoveLineItemAction))]
    public partial interface IMyCartRemoveLineItemAction : IMyCartUpdateAction
    {
        string LineItemId { get; set; }

        long? Quantity { get; set; }

        IMoney ExternalPrice { get; set; }

        IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }

        IItemShippingDetailsDraft ShippingDetailsToRemove { get; set; }
    }
}
