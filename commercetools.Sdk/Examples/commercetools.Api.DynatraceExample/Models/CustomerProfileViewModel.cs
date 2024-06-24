namespace commercetools.Api.DynatraceExample.Models
{
    public class CustomerProfileViewModel : ICustomerProfile
    {
        public BaseCustomer Customer { get; set; }
        public MyCartViewModel ActiveCart { get; set; }
    }
}