namespace commercetools.Api.NewRelicExample.Models
{
    public interface ICustomerProfile
    {
        public BaseCustomer Customer { get; }
        public MyCartViewModel ActiveCart { get; }
    }
}