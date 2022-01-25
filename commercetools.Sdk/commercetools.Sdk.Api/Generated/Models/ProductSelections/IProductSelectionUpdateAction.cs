using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.ProductSelections.ProductSelectionUpdateAction))]
    [SubTypeDiscriminator("addProduct", typeof(commercetools.Api.Models.ProductSelections.ProductSelectionAddProductAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Api.Models.ProductSelections.ProductSelectionChangeNameAction))]
    [SubTypeDiscriminator("removeProduct", typeof(commercetools.Api.Models.ProductSelections.ProductSelectionRemoveProductAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.ProductSelections.ProductSelectionSetKeyAction))]
    public partial interface IProductSelectionUpdateAction
    {
        string Action { get; set; }
    }
}
