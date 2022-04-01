using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.CustomerGroups
{
    public partial class CustomerGroupDraft : ICustomerGroupDraft
    {
        public string Key { get; set; }

        public string GroupName { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
