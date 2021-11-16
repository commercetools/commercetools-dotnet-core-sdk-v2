using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customers
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Customers.CustomerImport))]
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
