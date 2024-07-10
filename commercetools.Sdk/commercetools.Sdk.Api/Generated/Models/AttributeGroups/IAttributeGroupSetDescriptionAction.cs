using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupSetDescriptionAction))]
    public partial interface IAttributeGroupSetDescriptionAction : IAttributeGroupUpdateAction
    {
        ILocalizedString Description { get; set; }

    }
}
