using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Customers.CustomerImport))]
    public partial interface ICustomerImport : IImportResource
    {
        string CustomerNumber { get; set; }

        string Email { get; set; }

        string Password { get; set; }

        List<IStoreKeyReference> Stores { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string MiddleName { get; set; }

        string Title { get; set; }

        string Salutation { get; set; }

        string ExternalId { get; set; }

        DateTime? DateOfBirth { get; set; }

        string CompanyName { get; set; }

        string VatId { get; set; }

        bool? IsEmailVerified { get; set; }

        ICustomerGroupKeyReference CustomerGroup { get; set; }

        List<ICustomerAddress> Addresses { get; set; }

        int? DefaultBillingAddress { get; set; }

        List<int> BillingAddresses { get; set; }

        int? DefaultShippingAddress { get; set; }

        List<int> ShippingAddresses { get; set; }

        string Locale { get; set; }

        ICustom Custom { get; set; }
    }
}
