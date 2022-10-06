using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


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

        ICustomFields Custom { get; set; }

        List<IBaseAddress> Addresses { get; set; }

        List<int> ShippingAddresses { get; set; }

        int? DefaultShipingAddress { get; set; }

        List<int> BillingAddresses { get; set; }

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
