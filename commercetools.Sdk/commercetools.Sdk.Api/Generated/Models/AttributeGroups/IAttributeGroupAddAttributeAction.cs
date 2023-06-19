using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupAddAttributeAction))]
    public partial interface IAttributeGroupAddAttributeAction : IAttributeGroupUpdateAction
    {
        IAttributeReference Attribute { get; set; }

    }
}
