using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerDraft))]
    public partial interface ICustomerDraft
    {
        string CustomerNumber { get; set; }

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

        DateTime? DateOfBirth { get; set; }

        string CompanyName { get; set; }

        string VatId { get; set; }

        List<IBaseAddress> Addresses { get; set; }

        int? DefaultShippingAddress { get; set; }

        List<int> ShippingAddresses { get; set; }

        int? DefaultBillingAddress { get; set; }

        List<int> BillingAddresses { get; set; }

        bool? IsEmailVerified { get; set; }

        string ExternalId { get; set; }

        ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        string Locale { get; set; }

        string Salutation { get; set; }

        string Key { get; set; }

        List<IStoreResourceIdentifier> Stores { get; set; }

        IAuthenticationMode AuthenticationMode { get; set; }
    }
}
