using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetTitleAction))]
    public partial interface ICustomerSetTitleAction : ICustomerUpdateAction
    {
        string Title { get; set; }
    }
}
