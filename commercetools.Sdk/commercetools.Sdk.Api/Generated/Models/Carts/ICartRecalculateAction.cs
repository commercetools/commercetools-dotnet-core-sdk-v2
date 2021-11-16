using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartRecalculateAction))]
    public partial interface ICartRecalculateAction : ICartUpdateAction
    {
        bool? UpdateProductData { get; set;}
    }
}
