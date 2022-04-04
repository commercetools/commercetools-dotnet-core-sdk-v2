using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartSetLineItemShippingDetailsAction))]
    public partial interface IMyCartSetLineItemShippingDetailsAction : IMyCartUpdateAction
    {
        string LineItemId { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
