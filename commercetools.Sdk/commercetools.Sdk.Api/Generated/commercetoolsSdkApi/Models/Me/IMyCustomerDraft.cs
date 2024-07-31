using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.Models;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCustomerDraft))]
    public partial interface IMyCustomerDraft
    {
        string Email { get; set; }

        string Password { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string MiddleName { get; set; }

        string Title { get; set; }

        string Salutation { get; set; }

        Date? DateOfBirth { get; set; }

        string CompanyName { get; set; }

        string VatId { get; set; }

        IList<IBaseAddress> Addresses { get; set; }

        IEnumerable<IBaseAddress> AddressesEnumerable { set => Addresses = value.ToList(); }

        long? DefaultShippingAddress { get; set; }

        long? DefaultBillingAddress { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        string Locale { get; set; }

        IList<IStoreResourceIdentifier> Stores { get; set; }

        IEnumerable<IStoreResourceIdentifier> StoresEnumerable { set => Stores = value.ToList(); }

    }
}
