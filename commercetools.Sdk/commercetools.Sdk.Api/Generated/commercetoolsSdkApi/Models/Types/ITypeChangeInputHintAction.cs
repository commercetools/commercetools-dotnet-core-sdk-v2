using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeChangeInputHintAction))]
    public partial interface ITypeChangeInputHintAction : ITypeUpdateAction
    {
        string FieldName { get; set; }

        ITypeTextInputHint InputHint { get; set; }

    }
}
