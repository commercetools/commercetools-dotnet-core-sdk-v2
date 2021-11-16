using commercetools.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSignInResult))]
    public partial interface ICustomerSignInResult
    {
        ICustomer Customer { get; set; }

        ICart Cart { get; set; }
    }
}
