using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeReference))]
    public partial interface ITypeReference : IReference
    {
        IType Obj { get; set;}
    }
}
