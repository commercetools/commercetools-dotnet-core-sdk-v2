using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.Models;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.CustomerDraft))]
    public partial interface ICustomerDraft
    {
        string Key { get; set; }

        string CustomerNumber { get; set; }

        string ExternalId { get; set; }

        string Email { get; set; }

        string Password { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string MiddleName { get; set; }

        string Title { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        string AnonymousCartId { get; set; }

        ICartResourceIdentifier AnonymousCart { get; set; }

        string AnonymousId { get; set; }

        Date? DateOfBirth { get; set; }

        string CompanyName { get; set; }

        string VatId { get; set; }

        IList<IBaseAddress> Addresses { get; set; }

        IEnumerable<IBaseAddress> AddressesEnumerable { set => Addresses = value.ToList(); }

        int? DefaultShippingAddress { get; set; }

        IList<int> ShippingAddresses { get; set; }

        IEnumerable<int> ShippingAddressesEnumerable { set => ShippingAddresses = value.ToList(); }

        int? DefaultBillingAddress { get; set; }

        IList<int> BillingAddresses { get; set; }

        IEnumerable<int> BillingAddressesEnumerable { set => BillingAddresses = value.ToList(); }

        bool? IsEmailVerified { get; set; }

        ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        string Locale { get; set; }

        string Salutation { get; set; }

        IList<IStoreResourceIdentifier> Stores { get; set; }

        IEnumerable<IStoreResourceIdentifier> StoresEnumerable { set => Stores = value.ToList(); }

        IAuthenticationMode AuthenticationMode { get; set; }

    }
}
