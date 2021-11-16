using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeInputHintAction))]
    public partial interface IProductTypeChangeInputHintAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set;}
        
        ITextInputHint NewValue { get; set;}
    }
}
