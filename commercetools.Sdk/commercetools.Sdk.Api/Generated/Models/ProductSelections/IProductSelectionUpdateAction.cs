using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionUpdateAction))]
    [SubTypeDiscriminator("addProduct", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionAddProductAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionChangeNameAction))]
    [SubTypeDiscriminator("removeProduct", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionRemoveProductAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetCustomTypeAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetKeyAction))]
    public partial interface IProductSelectionUpdateAction
    {
        string Action { get; set; }
    }
}
