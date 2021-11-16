using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeResourceIdentifier))]
    public partial interface ITypeResourceIdentifier : IResourceIdentifier
    {
    }
}
