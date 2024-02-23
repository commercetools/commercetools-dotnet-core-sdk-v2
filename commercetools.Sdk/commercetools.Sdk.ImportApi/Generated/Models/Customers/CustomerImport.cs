using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Customers
{

    public partial class CustomerImport : ICustomerImport
    {
        public string Key { get; set; }

        public string CustomerNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public IList<IStoreKeyReference> Stores { get; set; }
        public IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Title { get; set; }

        public string Salutation { get; set; }

        public string ExternalId { get; set; }

        public Date? DateOfBirth { get; set; }

        public string CompanyName { get; set; }

        public string VatId { get; set; }

        public bool? IsEmailVerified { get; set; }

        public ICustomerGroupKeyReference CustomerGroup { get; set; }

        public IList<ICustomerAddress> Addresses { get; set; }
        public IEnumerable<ICustomerAddress> AddressesEnumerable { set => Addresses = value.ToList(); }


        public int? DefaultBillingAddress { get; set; }

        public IList<int> BillingAddresses { get; set; }
        public IEnumerable<int> BillingAddressesEnumerable { set => BillingAddresses = value.ToList(); }


        public int? DefaultShippingAddress { get; set; }

        public IList<int> ShippingAddresses { get; set; }
        public IEnumerable<int> ShippingAddressesEnumerable { set => ShippingAddresses = value.ToList(); }


        public string Locale { get; set; }

        public ICustom Custom { get; set; }

        public IAuthenticationMode AuthenticationMode { get; set; }
    }
}
