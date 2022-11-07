using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupAddAttributeAction))]
    public partial interface IAttributeGroupAddAttributeAction : IAttributeGroupUpdateAction
    {
        IAttributeReference Attribute { get; set; }

    }
}
