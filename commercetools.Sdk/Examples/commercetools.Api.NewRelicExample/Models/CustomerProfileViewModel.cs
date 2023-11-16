namespace commercetools.Api.NewRelicExample.Models
{
    public class CustomerProfileViewModel : ICustomerProfile
    {
        public BaseCustomer Customer { get; set; }
        public MyCartViewModel ActiveCart { get; set; }
    }
}