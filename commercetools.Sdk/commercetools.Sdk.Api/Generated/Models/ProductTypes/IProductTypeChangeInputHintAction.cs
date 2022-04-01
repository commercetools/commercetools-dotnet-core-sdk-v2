using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTypes.ProductTypeChangeInputHintAction))]
    public partial interface IProductTypeChangeInputHintAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        ITextInputHint NewValue { get; set; }
    }
}
