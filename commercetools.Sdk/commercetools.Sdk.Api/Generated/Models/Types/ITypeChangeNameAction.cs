using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeChangeNameAction))]
    public partial interface ITypeChangeNameAction : ITypeUpdateAction
    {
        ILocalizedString Name { get; set;}
    }
}
