using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupRemoveAttributeAction))]
    public partial interface IAttributeGroupRemoveAttributeAction : IAttributeGroupUpdateAction
    {
        IAttributeReference Attribute { get; set; }

    }
}
