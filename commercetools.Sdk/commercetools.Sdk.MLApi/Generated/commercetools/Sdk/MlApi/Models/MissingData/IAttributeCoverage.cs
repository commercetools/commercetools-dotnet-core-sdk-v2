using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.AttributeCoverage))]
    public partial interface IAttributeCoverage
    {
        decimal Names { get; set; }

        decimal Values { get; set; }
    }
}
