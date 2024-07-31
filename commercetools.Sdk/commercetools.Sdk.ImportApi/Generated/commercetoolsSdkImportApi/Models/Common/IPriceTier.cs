using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.PriceTier))]
    public partial interface IPriceTier
    {
        long MinimumQuantity { get; set; }

        ITypedMoney Value { get; set; }

    }
}
