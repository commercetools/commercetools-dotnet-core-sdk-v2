using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscount))]
    public partial interface IProductDiscount : IBaseResource
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

        IProductDiscountValue Value { get; set; }

        string Predicate { get; set; }

        string SortOrder { get; set; }

        bool IsActive { get; set; }

        IList<IReference> References { get; set; }
        IEnumerable<IReference> ReferencesEnumerable { set => References = value.ToList(); }


        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

    }
}
