using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingAttributesDetails))]
    public partial interface IMissingAttributesDetails 
    {
        int Total { get; set;}
        
        int MissingAttributeNames { get; set;}
        
        int MissingAttributeValues { get; set;}
    }
}
