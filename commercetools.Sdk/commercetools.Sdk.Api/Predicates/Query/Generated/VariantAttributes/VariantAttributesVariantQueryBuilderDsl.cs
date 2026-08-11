using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.VariantAttributes
{

    public partial class VariantAttributesVariantQueryBuilderDsl
    {
        public VariantAttributesVariantQueryBuilderDsl()
        {
        }

        public static VariantAttributesVariantQueryBuilderDsl Of()
        {
            return new VariantAttributesVariantQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantAttributesVariantQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<VariantAttributesVariantQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<VariantAttributesVariantQueryBuilderDsl>(p, VariantAttributesVariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantAttributesVariantQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<VariantAttributesVariantQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<VariantAttributesVariantQueryBuilderDsl>(p, VariantAttributesVariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantAttributesVariantQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<VariantAttributesVariantQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<VariantAttributesVariantQueryBuilderDsl>(p, VariantAttributesVariantQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantAttributesVariantQueryBuilderDsl> Availability(
            Func<commercetools.Sdk.Api.Predicates.Query.VariantAttributes.VariantAttributesAvailabilityQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.VariantAttributes.VariantAttributesAvailabilityQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantAttributesVariantQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("availability"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.VariantAttributes.VariantAttributesAvailabilityQueryBuilderDsl.Of())),
                VariantAttributesVariantQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<VariantAttributesVariantQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantAttributesVariantQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                VariantAttributesVariantQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantAttributesVariantQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<VariantAttributesVariantQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<VariantAttributesVariantQueryBuilderDsl>(p, VariantAttributesVariantQueryBuilderDsl.Of));
        }

    }
}
