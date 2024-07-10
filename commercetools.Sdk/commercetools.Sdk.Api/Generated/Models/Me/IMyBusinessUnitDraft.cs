using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [TypeDiscriminator(nameof(UnitType))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitDraft))]
    [SubTypeDiscriminator("Company", typeof(commercetools.Sdk.Api.Models.Me.MyCompanyDraft))]
    [SubTypeDiscriminator("Division", typeof(commercetools.Sdk.Api.Models.Me.MyDivisionDraft))]
    public partial interface IMyBusinessUnitDraft
    {
        string Key { get; set; }

        IBusinessUnitType UnitType { get; set; }

        string Name { get; set; }

        string ContactEmail { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IList<IBaseAddress> Addresses { get; set; }
        IEnumerable<IBaseAddress> AddressesEnumerable { set => Addresses = value.ToList(); }


        IList<int> ShippingAddresses { get; set; }
        IEnumerable<int> ShippingAddressesEnumerable { set => ShippingAddresses = value.ToList(); }


        int? DefaultShippingAddress { get; set; }

        IList<int> BillingAddresses { get; set; }
        IEnumerable<int> BillingAddressesEnumerable { set => BillingAddresses = value.ToList(); }


        int? DefaultBillingAddress { get; set; }

        static commercetools.Sdk.Api.Models.Me.MyCompanyDraft Company(Action<commercetools.Sdk.Api.Models.Me.MyCompanyDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyCompanyDraft();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Me.MyDivisionDraft Division(Action<commercetools.Sdk.Api.Models.Me.MyDivisionDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyDivisionDraft();
            init?.Invoke(t);
            return t;
        }
    }
}
