using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Customers
{
    public partial class CustomerImport : ICustomerImport
    {
        public string Key { get; set; }

        public string CustomerNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public List<IStoreKeyReference> Stores { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Title { get; set; }

        public string Salutation { get; set; }

        public string ExternalId { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string CompanyName { get; set; }

        public string VatId { get; set; }

        public bool? IsEmailVerified { get; set; }

        public ICustomerGroupKeyReference CustomerGroup { get; set; }

        public List<ICustomerAddress> Addresses { get; set; }

        public int? DefaultBillingAddress { get; set; }

        public List<int> BillingAddresses { get; set; }

        public int? DefaultShippingAddress { get; set; }

        public List<int> ShippingAddresses { get; set; }

        public string Locale { get; set; }

        public ICustom Custom { get; set; }
    }
}
