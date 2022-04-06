using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.AttributeCoverage))]
    public partial interface IAttributeCoverage
    {
        double Names { get; set; }

        double Values { get; set; }
    }
}
