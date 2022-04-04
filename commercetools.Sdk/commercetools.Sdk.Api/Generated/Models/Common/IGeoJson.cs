using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Common.GeoJson))]
    [SubTypeDiscriminator("Point", typeof(commercetools.Sdk.Api.Models.Common.GeoJsonPoint))]
    public partial interface IGeoJson
    {
        string Type { get; set; }
    }
}
