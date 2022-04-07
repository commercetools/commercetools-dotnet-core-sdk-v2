using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingPricesMeta))]
    public partial interface IMissingPricesMeta
    {
        IMissingPricesProductLevel ProductLevel { get; set; }

        IMissingPricesVariantLevel VariantLevel { get; set; }
    }
}
