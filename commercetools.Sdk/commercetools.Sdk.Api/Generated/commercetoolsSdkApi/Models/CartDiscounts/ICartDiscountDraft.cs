using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.DiscountGroups;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountDraft))]
    public partial interface ICartDiscountDraft
    {
        ILocalizedString Name { get; set; }

        string Key { get; set; }

        ILocalizedString Description { get; set; }

        ICartDiscountValueDraft Value { get; set; }

        string CartPredicate { get; set; }

        ICartDiscountTarget Target { get; set; }

        string SortOrder { get; set; }

        IList<IStoreResourceIdentifier> Stores { get; set; }

        IEnumerable<IStoreResourceIdentifier> StoresEnumerable { set => Stores = value.ToList(); }

        bool? IsActive { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        bool? RequiresDiscountCode { get; set; }

        IStackingMode StackingMode { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IDiscountGroupResourceIdentifier DiscountGroup { get; set; }

    }
}
