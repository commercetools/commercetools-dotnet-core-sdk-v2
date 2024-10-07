namespace commercetools.Api.ApmExample.Models
{
    public interface ICustomerProfile
    {
        public BaseCustomer Customer { get; }
        public MyCartViewModel ActiveCart { get; }
    }
}