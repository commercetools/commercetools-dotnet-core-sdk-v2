using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customfields.BooleanField))]
    public partial interface IBooleanField : ICustomField
    {
        bool Value { get; set; }

    }
}
