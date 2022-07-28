using System;
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
    [SubTypeDiscriminator("setVariantSelection", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetVariantSelectionAction))]
    public partial interface IProductSelectionUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<IProductSelectionUpdateAction>
    {
        new string Action { get; set; }

        static commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionAddProductAction AddProduct(Action<commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionAddProductAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionAddProductAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionRemoveProductAction RemoveProduct(Action<commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionRemoveProductAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionRemoveProductAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetVariantSelectionAction SetVariantSelection(Action<commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetVariantSelectionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductSelections.ProductSelectionSetVariantSelectionAction();
            init?.Invoke(t);
            return t;
        }
    }
}
