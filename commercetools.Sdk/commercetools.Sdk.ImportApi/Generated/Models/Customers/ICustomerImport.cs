using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customers;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customers.CustomerImport))]
    public partial interface ICustomerImport : IImportResource
    {
        new string Key { get; set; }

        string CustomerNumber { get; set; }

        string Email { get; set; }

        string Password { get; set; }

        IList<IStoreKeyReference> Stores { get; set; }
        IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }


        string FirstName { get; set; }

        string LastName { get; set; }

        string MiddleName { get; set; }

        string Title { get; set; }

        string Salutation { get; set; }

        string ExternalId { get; set; }

        Date? DateOfBirth { get; set; }

        string CompanyName { get; set; }

        string VatId { get; set; }

        bool? IsEmailVerified { get; set; }

        ICustomerGroupKeyReference CustomerGroup { get; set; }

        IList<ICustomerAddress> Addresses { get; set; }
        IEnumerable<ICustomerAddress> AddressesEnumerable { set => Addresses = value.ToList(); }


        int? DefaultBillingAddress { get; set; }

        IList<int> BillingAddresses { get; set; }
        IEnumerable<int> BillingAddressesEnumerable { set => BillingAddresses = value.ToList(); }


        int? DefaultShippingAddress { get; set; }

        IList<int> ShippingAddresses { get; set; }
        IEnumerable<int> ShippingAddressesEnumerable { set => ShippingAddresses = value.ToList(); }


        string Locale { get; set; }

        ICustom Custom { get; set; }

        IAuthenticationMode AuthenticationMode { get; set; }

    }
}
