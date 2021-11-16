using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeChangeInputHintAction))]
    public partial interface ITypeChangeInputHintAction : ITypeUpdateAction
    {
        string FieldName { get; set;}
        
        ITypeTextInputHint InputHint { get; set;}
    }
}
