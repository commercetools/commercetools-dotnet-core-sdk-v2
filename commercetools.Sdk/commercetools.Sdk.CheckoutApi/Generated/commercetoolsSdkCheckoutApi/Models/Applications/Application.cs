using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class Application : IApplication
    {
        public string Id { get; set; }

        public int Version { get; set; }

        public string Key { get; set; }

        public IApplicationStatus Status { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IApplicationLogo Logo { get; set; }

        public IList<string> Countries { get; set; }

        public IEnumerable<string> CountriesEnumerable { set => Countries = value.ToList(); }

        public IAllowedOrigins AllowedOrigins { get; set; }

        public IApplicationMode Mode { get; set; }

        public IPaymentsConfiguration PaymentsConfiguration { get; set; }

        public IList<IApplicationAgreement> Agreements { get; set; }

        public IEnumerable<IApplicationAgreement> AgreementsEnumerable { set => Agreements = value.ToList(); }

        public IDiscountsConfiguration DiscountsConfiguration { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }
    }
}
