using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupChangeNameAction))]
    public partial interface IAttributeGroupChangeNameAction : IAttributeGroupUpdateAction
    {
        ILocalizedString Name { get; set; }

    }
}
