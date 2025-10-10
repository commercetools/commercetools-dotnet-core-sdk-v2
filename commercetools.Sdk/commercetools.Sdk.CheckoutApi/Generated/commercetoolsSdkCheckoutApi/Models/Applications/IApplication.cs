using commercetools.Sdk.CheckoutApi.Models.PaymentIntegrations;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Applications
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Applications.Application))]
    public partial interface IApplication
    {
        string Id { get; set; }

        int Version { get; set; }

        string Key { get; set; }

        IApplicationStatus Status { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        IApplicationLogo Logo { get; set; }

        IList<string> Countries { get; set; }

        IEnumerable<string> CountriesEnumerable { set => Countries = value.ToList(); }

        IAllowedOrigins AllowedOrigins { get; set; }

        IApplicationMode Mode { get; set; }

        IPaymentsConfiguration PaymentsConfiguration { get; set; }

        IList<IApplicationAgreement> Agreements { get; set; }

        IEnumerable<IApplicationAgreement> AgreementsEnumerable { set => Agreements = value.ToList(); }

        IDiscountsConfiguration DiscountsConfiguration { get; set; }

        DateTime CreatedAt { get; set; }

        ICreatedBy CreatedBy { get; set; }

        DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

    }
}
