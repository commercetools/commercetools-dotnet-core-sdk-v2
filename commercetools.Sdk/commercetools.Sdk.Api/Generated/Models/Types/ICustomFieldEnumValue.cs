using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.CustomFieldEnumValue))]
    public partial interface ICustomFieldEnumValue 
    {
        string Key { get; set;}
        
        string Label { get; set;}
    }
}
