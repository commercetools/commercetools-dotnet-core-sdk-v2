using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.MLApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.Common.Money))]
    public partial interface IMoney
    {
        long CentAmount { get; set; }

        string CurrencyCode { get; set; }

    }
}
