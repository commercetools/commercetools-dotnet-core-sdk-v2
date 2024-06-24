namespace commercetools.Api.DynatraceExample.Models
{
    public interface ICustomerProfile
    {
        public BaseCustomer Customer { get; }
        public MyCartViewModel ActiveCart { get; }
    }
}