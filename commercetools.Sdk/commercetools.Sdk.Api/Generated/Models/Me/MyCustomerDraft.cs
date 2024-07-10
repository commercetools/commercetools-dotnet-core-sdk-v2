using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCustomerDraft : IMyCustomerDraft
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Title { get; set; }

        public string Salutation { get; set; }

        public Date? DateOfBirth { get; set; }

        public string CompanyName { get; set; }

        public string VatId { get; set; }

        public IList<IBaseAddress> Addresses { get; set; }
        public IEnumerable<IBaseAddress> AddressesEnumerable { set => Addresses = value.ToList(); }


        public long? DefaultShippingAddress { get; set; }

        public long? DefaultBillingAddress { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public string Locale { get; set; }

        public IList<IStoreResourceIdentifier> Stores { get; set; }
        public IEnumerable<IStoreResourceIdentifier> StoresEnumerable { set => Stores = value.ToList(); }

    }
}
