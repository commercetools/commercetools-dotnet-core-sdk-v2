using commercetools.Api.Models.Carts;
using System;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerSignin : ICustomerSignin
    {
        public string Email { get; set; }

        public string Password { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public string AnonymousCartId { get; set; }

        public ICartResourceIdentifier AnonymousCart { get; set; }

        public IAnonymousCartSignInMode AnonymousCartSignInMode { get; set; }

        public string AnonymousId { get; set; }

        public bool? UpdateProductData { get; set; }
    }
}
