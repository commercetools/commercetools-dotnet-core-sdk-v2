using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.Attribution))]
    public partial interface IAttribution
    {
        string ClientId { get; set; }

        IAttributionSource Source { get; set; }

    }
}
