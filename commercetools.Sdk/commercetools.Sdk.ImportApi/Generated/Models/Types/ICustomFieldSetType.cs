using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Types.CustomFieldSetType))]
    public partial interface ICustomFieldSetType : IFieldType
    {
        IFieldType ElementType { get; set; }

    }
}
