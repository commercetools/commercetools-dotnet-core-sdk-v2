using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodQueryBuilderDsl
    {
        public ShippingMethodQueryBuilderDsl()
        {
        }

        public static ShippingMethodQueryBuilderDsl Of()
        {
            return new ShippingMethodQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(p, ShippingMethodQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(p, ShippingMethodQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(p, ShippingMethodQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(p, ShippingMethodQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ShippingMethodQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingMethodQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ShippingMethodQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(p, ShippingMethodQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(p, ShippingMethodQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodQueryBuilderDsl> LocalizedName(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("localizedName"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShippingMethodQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(p, ShippingMethodQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodQueryBuilderDsl> LocalizedDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("localizedDescription"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShippingMethodQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingMethodQueryBuilderDsl> TaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxCategory"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryReferenceQueryBuilderDsl.Of())),
                ShippingMethodQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingMethodQueryBuilderDsl> ZoneRates(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ZoneRateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ZoneRateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("zoneRates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ZoneRateQueryBuilderDsl.Of())),
                ShippingMethodQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ShippingMethodQueryBuilderDsl> ZoneRates()
        {
            return new CollectionPredicateBuilder<ShippingMethodQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("zoneRates")),
                    p => new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(p, ShippingMethodQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, bool> IsDefault()
        {
            return new ComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isDefault")),
            p => new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(p, ShippingMethodQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<ShippingMethodQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(p, ShippingMethodQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                ShippingMethodQueryBuilderDsl.Of);
        }


    }
}
