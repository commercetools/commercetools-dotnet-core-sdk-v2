using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Common.GeoJson))]
    [SubTypeDiscriminator("Point", typeof(commercetools.Api.Models.Common.GeoJsonPoint))]
    public partial interface IGeoJson 
    {
        string Type { get; set;}
    }
}
