using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartRecalculateAction))]
    public partial interface ICartRecalculateAction : ICartUpdateAction
    {
        bool? UpdateProductData { get; set; }
    }
}
