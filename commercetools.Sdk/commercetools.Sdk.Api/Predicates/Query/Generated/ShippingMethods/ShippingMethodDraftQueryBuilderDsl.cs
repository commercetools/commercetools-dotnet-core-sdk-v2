using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodDraftQueryBuilderDsl
    {
        public ShippingMethodDraftQueryBuilderDsl()
        {
        }

        public static ShippingMethodDraftQueryBuilderDsl Of()
        {
            return new ShippingMethodDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ShippingMethodDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl>(p, ShippingMethodDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodDraftQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ShippingMethodDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl>(p, ShippingMethodDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl> LocalizedName(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("localizedName"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShippingMethodDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShippingMethodDraftQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<ShippingMethodDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl>(p, ShippingMethodDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl> LocalizedDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("localizedDescription"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShippingMethodDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl> TaxCategory(
            Func<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("taxCategory"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.TaxCategories.TaxCategoryResourceIdentifierQueryBuilderDsl.Of())),
                ShippingMethodDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl> ZoneRates(
            Func<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ZoneRateDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ZoneRateDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("zoneRates"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShippingMethods.ZoneRateDraftQueryBuilderDsl.Of())),
                ShippingMethodDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ShippingMethodDraftQueryBuilderDsl> ZoneRates()
        {
            return new CollectionPredicateBuilder<ShippingMethodDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("zoneRates")),
                    p => new CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl>(p, ShippingMethodDraftQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ShippingMethodDraftQueryBuilderDsl, bool> Active()
        {
            return new ComparisonPredicateBuilder<ShippingMethodDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("active")),
            p => new CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl>(p, ShippingMethodDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodDraftQueryBuilderDsl, bool> IsDefault()
        {
            return new ComparisonPredicateBuilder<ShippingMethodDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isDefault")),
            p => new CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl>(p, ShippingMethodDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodDraftQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<ShippingMethodDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl>(p, ShippingMethodDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShippingMethodDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                ShippingMethodDraftQueryBuilderDsl.Of);
        }


    }
}
