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

    public partial class Customer : ICustomer
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public string Key { get; set; }

        public string CustomerNumber { get; set; }

        public string ExternalId { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Title { get; set; }

        public Date? DateOfBirth { get; set; }

        public string CompanyName { get; set; }

        public string VatId { get; set; }

        public IList<IAddress> Addresses { get; set; }
        public IEnumerable<IAddress> AddressesEnumerable { set => Addresses = value.ToList(); }


        public string DefaultShippingAddressId { get; set; }

        public IList<string> ShippingAddressIds { get; set; }
        public IEnumerable<string> ShippingAddressIdsEnumerable { set => ShippingAddressIds = value.ToList(); }


        public string DefaultBillingAddressId { get; set; }

        public IList<string> BillingAddressIds { get; set; }
        public IEnumerable<string> BillingAddressIdsEnumerable { set => BillingAddressIds = value.ToList(); }


        public bool IsEmailVerified { get; set; }

        public ICustomerGroupReference CustomerGroup { get; set; }

        public ICustomFields Custom { get; set; }

        public string Locale { get; set; }

        public string Salutation { get; set; }

        public IList<IStoreKeyReference> Stores { get; set; }
        public IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }


        public IAuthenticationMode AuthenticationMode { get; set; }
    }
}
