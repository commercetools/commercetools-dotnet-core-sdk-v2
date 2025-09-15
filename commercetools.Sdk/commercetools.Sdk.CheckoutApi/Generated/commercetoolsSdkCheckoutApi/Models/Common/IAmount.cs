using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Common.Amount))]
    public partial interface IAmount
    {
        int CentAmount { get; set; }

        string CurrencyCode { get; set; }

    }
}
