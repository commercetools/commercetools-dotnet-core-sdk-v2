namespace commercetools.Api.CheckoutApp.Models
{
    public interface ICustomerProfile
    {
        public BaseCustomer Customer { get; }
        public MyCartViewModel ActiveCart { get; }
    }
}