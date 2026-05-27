using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionResourceIdentifier))]
    public partial interface IExtensionResourceIdentifier : IResourceIdentifier
    {
        new IReferenceTypeId TypeId { get; set; }

        new string Id { get; set; }

        new string Key { get; set; }

    }
}
