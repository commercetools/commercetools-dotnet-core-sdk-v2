using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.AttributeCoverage))]
    public partial interface IAttributeCoverage 
    {
        double Names { get; set;}
        
        double Values { get; set;}
    }
}
