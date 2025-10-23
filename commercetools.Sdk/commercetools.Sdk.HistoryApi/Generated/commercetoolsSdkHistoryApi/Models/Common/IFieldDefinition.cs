using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.FieldDefinition))]
    public partial interface IFieldDefinition
    {
        IFieldType Type { get; set; }

        string Name { get; set; }

        ILocalizedString Label { get; set; }

        bool Required { get; set; }

        ITypeTextInputHint InputHint { get; set; }

    }
}
