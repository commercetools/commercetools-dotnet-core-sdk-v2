using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.AttributeGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AttributeGroups.AttributeReference))]
    public partial interface IAttributeReference
    {
        string Key { get; set; }

    }
}
