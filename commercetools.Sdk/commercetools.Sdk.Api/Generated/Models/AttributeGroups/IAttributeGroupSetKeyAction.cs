using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeGroupSetKeyAction))]
    public partial interface IAttributeGroupSetKeyAction : IAttributeGroupUpdateAction
    {
        string Key { get; set; }

    }
}
