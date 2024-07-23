using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.TextAttribute))]
    public partial interface ITextAttribute : IAttribute
    {
        string Value { get; set; }

    }
}
