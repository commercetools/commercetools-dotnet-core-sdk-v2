using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.EnumAttribute))]
    public partial interface IEnumAttribute : IAttribute
    {
        string Value { get; set; }

    }
}
