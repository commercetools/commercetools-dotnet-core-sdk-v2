using commercetools.Api.Models.Common;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyCustomerDraft : IMyCustomerDraft
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Title { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string CompanyName { get; set; }

        public string VatId { get; set; }

        public List<IBaseAddress> Addresses { get; set; }

        public long? DefaultShippingAddress { get; set; }

        public long? DefaultBillingAddress { get; set; }

        public ICustomFields Custom { get; set; }

        public string Locale { get; set; }

        public List<IStoreResourceIdentifier> Stores { get; set; }
    }
}
