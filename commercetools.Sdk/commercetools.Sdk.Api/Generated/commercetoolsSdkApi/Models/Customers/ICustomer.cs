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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Customers.Customer))]
    public partial interface ICustomer : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        string Key { get; set; }

        string CustomerNumber { get; set; }

        string ExternalId { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string Email { get; set; }

        string Password { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string MiddleName { get; set; }

        string Title { get; set; }

        Date? DateOfBirth { get; set; }

        string CompanyName { get; set; }

        string VatId { get; set; }

        IList<IAddress> Addresses { get; set; }

        IEnumerable<IAddress> AddressesEnumerable { set => Addresses = value.ToList(); }

        string DefaultShippingAddressId { get; set; }

        IList<string> ShippingAddressIds { get; set; }

        IEnumerable<string> ShippingAddressIdsEnumerable { set => ShippingAddressIds = value.ToList(); }

        string DefaultBillingAddressId { get; set; }

        IList<string> BillingAddressIds { get; set; }

        IEnumerable<string> BillingAddressIdsEnumerable { set => BillingAddressIds = value.ToList(); }

        bool IsEmailVerified { get; set; }

        ICustomerGroupReference CustomerGroup { get; set; }

        ICustomFields Custom { get; set; }

        string Locale { get; set; }

        string Salutation { get; set; }

        IList<IStoreKeyReference> Stores { get; set; }

        IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }

        IAuthenticationMode AuthenticationMode { get; set; }

        IList<ICustomerGroupAssignment> CustomerGroupAssignments { get; set; }

        IEnumerable<ICustomerGroupAssignment> CustomerGroupAssignmentsEnumerable { set => CustomerGroupAssignments = value.ToList(); }

    }
}
