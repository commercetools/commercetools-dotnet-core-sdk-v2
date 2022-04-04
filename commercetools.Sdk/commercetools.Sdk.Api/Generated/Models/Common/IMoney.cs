using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.Money))]
    public partial interface IMoney
    {
        long CentAmount { get; set; }

        string CurrencyCode { get; set; }
    }
}
