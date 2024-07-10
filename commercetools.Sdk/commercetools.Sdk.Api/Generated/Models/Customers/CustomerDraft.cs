using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerDraft : ICustomerDraft
    {
        public string Key { get; set; }

        public string CustomerNumber { get; set; }

        public string ExternalId { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Title { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public string AnonymousCartId { get; set; }

        public ICartResourceIdentifier AnonymousCart { get; set; }

        public string AnonymousId { get; set; }

        public Date? DateOfBirth { get; set; }

        public string CompanyName { get; set; }

        public string VatId { get; set; }

        public IList<IBaseAddress> Addresses { get; set; }
        public IEnumerable<IBaseAddress> AddressesEnumerable { set => Addresses = value.ToList(); }


        public int? DefaultShippingAddress { get; set; }

        public IList<int> ShippingAddresses { get; set; }
        public IEnumerable<int> ShippingAddressesEnumerable { set => ShippingAddresses = value.ToList(); }


        public int? DefaultBillingAddress { get; set; }

        public IList<int> BillingAddresses { get; set; }
        public IEnumerable<int> BillingAddressesEnumerable { set => BillingAddresses = value.ToList(); }


        public bool? IsEmailVerified { get; set; }

        public ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public string Locale { get; set; }

        public string Salutation { get; set; }

        public IList<IStoreResourceIdentifier> Stores { get; set; }
        public IEnumerable<IStoreResourceIdentifier> StoresEnumerable { set => Stores = value.ToList(); }


        public IAuthenticationMode AuthenticationMode { get; set; }
    }
}
