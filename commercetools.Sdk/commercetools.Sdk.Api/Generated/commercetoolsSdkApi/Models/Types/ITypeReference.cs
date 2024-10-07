using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeReference))]
    public partial interface ITypeReference : IReference
    {
        new string Id { get; set; }

        IType Obj { get; set; }

    }
}
