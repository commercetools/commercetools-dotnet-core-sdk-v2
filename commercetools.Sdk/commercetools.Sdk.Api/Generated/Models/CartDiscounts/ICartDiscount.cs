using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscount))]
    public partial interface ICartDiscount : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        ILocalizedString Name { get; set; }

        string Key { get; set; }

        ILocalizedString Description { get; set; }

        ICartDiscountValue Value { get; set; }

        string CartPredicate { get; set; }

        ICartDiscountTarget Target { get; set; }

        string SortOrder { get; set; }

        bool IsActive { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        bool RequiresDiscountCode { get; set; }

        List<IReference> References { get; set; }

        IStackingMode StackingMode { get; set; }

        ICustomFields Custom { get; set; }

    }
}
