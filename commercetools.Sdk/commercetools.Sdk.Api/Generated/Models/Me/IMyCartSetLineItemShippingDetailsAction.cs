using commercetools.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartSetLineItemShippingDetailsAction))]
    public partial interface IMyCartSetLineItemShippingDetailsAction : IMyCartUpdateAction
    {
        string LineItemId { get; set;}
        
        IItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
