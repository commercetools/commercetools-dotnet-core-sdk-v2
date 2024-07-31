

namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerChangePassword : ICustomerChangePassword
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public string CurrentPassword { get; set; }

        public string NewPassword { get; set; }
    }
}
