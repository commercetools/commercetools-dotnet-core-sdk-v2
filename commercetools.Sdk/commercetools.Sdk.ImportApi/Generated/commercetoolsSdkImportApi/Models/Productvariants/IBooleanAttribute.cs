using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.BooleanAttribute))]
    public partial interface IBooleanAttribute : IAttribute
    {
        bool Value { get; set; }

    }
}
