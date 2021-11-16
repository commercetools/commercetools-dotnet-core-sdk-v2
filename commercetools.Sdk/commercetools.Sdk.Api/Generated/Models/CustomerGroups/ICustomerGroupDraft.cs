using commercetools.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CustomerGroups
{
    [DeserializeAs(typeof(commercetools.Api.Models.CustomerGroups.CustomerGroupDraft))]
    public partial interface ICustomerGroupDraft 
    {
        string Key { get; set;}
        
        string GroupName { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
    }
}
