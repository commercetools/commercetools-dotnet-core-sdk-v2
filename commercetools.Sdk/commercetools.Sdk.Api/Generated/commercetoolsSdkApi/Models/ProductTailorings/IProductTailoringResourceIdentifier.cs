using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductTailorings
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductTailorings.ProductTailoringResourceIdentifier))]
    public partial interface IProductTailoringResourceIdentifier : IResourceIdentifier
    {
        new string Id { get; set; }

        new string Key { get; set; }

    }
}
