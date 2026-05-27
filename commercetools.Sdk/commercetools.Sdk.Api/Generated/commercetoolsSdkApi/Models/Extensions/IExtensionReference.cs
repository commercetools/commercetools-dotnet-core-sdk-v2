using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionReference))]
    public partial interface IExtensionReference : IReference
    {
        new IReferenceTypeId TypeId { get; set; }

        new string Id { get; set; }

        IExtension Obj { get; set; }

    }
}
