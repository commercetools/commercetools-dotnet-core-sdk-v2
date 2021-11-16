using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeSetDescriptionAction))]
    public partial interface ITypeSetDescriptionAction : ITypeUpdateAction
    {
        ILocalizedString Description { get; set;}
    }
}
