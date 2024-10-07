using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CustomObjects
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CustomObjects.CustomObjectReference))]
    public partial interface ICustomObjectReference : IReference
    {
        ICustomObject Obj { get; set; }

        new string Id { get; set; }

    }
}
