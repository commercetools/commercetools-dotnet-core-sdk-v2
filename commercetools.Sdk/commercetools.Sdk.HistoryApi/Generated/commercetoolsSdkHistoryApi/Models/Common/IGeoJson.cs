using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.HistoryApi.Models.Common.GeoJson))]
    [SubTypeDiscriminator("Point", typeof(commercetools.Sdk.HistoryApi.Models.Common.GeoLocation))]
    public partial interface IGeoJson
    {
        string Type { get; set; }

        static commercetools.Sdk.HistoryApi.Models.Common.GeoLocation Point(Action<commercetools.Sdk.HistoryApi.Models.Common.GeoLocation> init = null)
        {
            var t = new commercetools.Sdk.HistoryApi.Models.Common.GeoLocation();
            init?.Invoke(t);
            return t;
        }
    }
}
