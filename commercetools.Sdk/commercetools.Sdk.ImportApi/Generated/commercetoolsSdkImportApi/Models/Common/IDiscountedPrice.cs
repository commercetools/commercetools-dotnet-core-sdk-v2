using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.DiscountedPrice))]
    public partial interface IDiscountedPrice
    {
        ITypedMoney Value { get; set; }

        IProductDiscountKeyReference Discount { get; set; }

    }
}
