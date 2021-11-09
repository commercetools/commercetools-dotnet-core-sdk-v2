using commercetools.Api.Models.Customers;

namespace commercetools.Api.CheckoutApp.Models
{
    public class BaseCustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Name => $"{FirstName} {LastName}";

        public string Email { get; set; }
        public string Id { get; set; }
        public string CustomerNumber { get; set; }

        public BaseCustomer()
        {
            
        }
        public BaseCustomer(ICustomer customer)
        {
            if (customer != null)
            {
                FirstName = customer.FirstName;
                LastName = customer.LastName;
                Email = customer.Email;
                Id = customer.Id;
                CustomerNumber = customer.CustomerNumber;
            }
        }
    }
}