using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.VariantAttributes
{

    public partial class VariantAttributesQueryBuilderDsl
    {
        public VariantAttributesQueryBuilderDsl()
        {
        }

        public static VariantAttributesQueryBuilderDsl Of()
        {
            return new VariantAttributesQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantAttributesQueryBuilderDsl, string> ProductId()
        {
            return new ComparisonPredicateBuilder<VariantAttributesQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productId")),
            p => new CombinationQueryPredicate<VariantAttributesQueryBuilderDsl>(p, VariantAttributesQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantAttributesQueryBuilderDsl, string> ProductKey()
        {
            return new ComparisonPredicateBuilder<VariantAttributesQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productKey")),
            p => new CombinationQueryPredicate<VariantAttributesQueryBuilderDsl>(p, VariantAttributesQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantAttributesQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.VariantAttributes.VariantAttributesAttributeMetadataQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.VariantAttributes.VariantAttributesAttributeMetadataQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantAttributesQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.VariantAttributes.VariantAttributesAttributeMetadataQueryBuilderDsl.Of())),
                VariantAttributesQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantAttributesQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<VariantAttributesQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<VariantAttributesQueryBuilderDsl>(p, VariantAttributesQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<VariantAttributesQueryBuilderDsl> Variants(
            Func<commercetools.Sdk.Api.Predicates.Query.VariantAttributes.VariantAttributesVariantQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.VariantAttributes.VariantAttributesVariantQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantAttributesQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variants"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.VariantAttributes.VariantAttributesVariantQueryBuilderDsl.Of())),
                VariantAttributesQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantAttributesQueryBuilderDsl> Variants()
        {
            return new CollectionPredicateBuilder<VariantAttributesQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variants")),
                    p => new CombinationQueryPredicate<VariantAttributesQueryBuilderDsl>(p, VariantAttributesQueryBuilderDsl.Of));
        }

    }
}
