using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Common.GeoJson))]
    [SubTypeDiscriminator("Point", typeof(commercetools.Sdk.Api.Models.Common.GeoJsonPoint))]
    public partial interface IGeoJson
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.Common.GeoJsonPoint Point(Action<commercetools.Sdk.Api.Models.Common.GeoJsonPoint> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Common.GeoJsonPoint();
            init?.Invoke(t);
            return t;
        }
    }
}
