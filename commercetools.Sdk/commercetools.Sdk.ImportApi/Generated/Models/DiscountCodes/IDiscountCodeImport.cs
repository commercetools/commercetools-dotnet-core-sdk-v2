using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.DiscountCodes.DiscountCodeImport))]
    public partial interface IDiscountCodeImport : IImportResource
    {
        new string Key { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        string Code { get; set; }

        IList<ICartDiscountKeyReference> CartDiscounts { get; set; }
        IEnumerable<ICartDiscountKeyReference> CartDiscountsEnumerable { set => CartDiscounts = value.ToList(); }


        string CartPredicate { get; set; }

        bool IsActive { get; set; }

        long? MaxApplications { get; set; }

        long? MaxApplicationsPerCustomer { get; set; }

        IList<string> Groups { get; set; }
        IEnumerable<string> GroupsEnumerable { set => Groups = value.ToList(); }


        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        ICustom Custom { get; set; }

    }
}
