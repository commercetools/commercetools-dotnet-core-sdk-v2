using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantSetAttributesActionQueryBuilderDsl
    {
        public VariantSetAttributesActionQueryBuilderDsl()
        {
        }

        public static VariantSetAttributesActionQueryBuilderDsl Of()
        {
            return new VariantSetAttributesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantSetAttributesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantSetAttributesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantSetAttributesActionQueryBuilderDsl>(p, VariantSetAttributesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantSetAttributesActionQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantSetAttributesActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.AttributeQueryBuilderDsl.Of())),
                VariantSetAttributesActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantSetAttributesActionQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<VariantSetAttributesActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<VariantSetAttributesActionQueryBuilderDsl>(p, VariantSetAttributesActionQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<VariantSetAttributesActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<VariantSetAttributesActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<VariantSetAttributesActionQueryBuilderDsl>(p, VariantSetAttributesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
