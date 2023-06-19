using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Zones.Location))]
    public partial interface ILocation
    {
        string Country { get; set; }

        string State { get; set; }

    }
}
