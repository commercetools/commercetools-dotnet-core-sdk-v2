using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Productvariants
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productvariants.NumberAttribute))]
    public partial interface INumberAttribute : IAttribute
    {
        decimal Value { get; set; }

    }
}
