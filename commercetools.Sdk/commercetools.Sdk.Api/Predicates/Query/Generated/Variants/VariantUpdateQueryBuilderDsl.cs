using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantUpdateQueryBuilderDsl
    {
        public VariantUpdateQueryBuilderDsl()
        {
        }

        public static VariantUpdateQueryBuilderDsl Of()
        {
            return new VariantUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<VariantUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<VariantUpdateQueryBuilderDsl>(p, VariantUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantUpdateActionQueryBuilderDsl.Of())),
                VariantUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<VariantUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<VariantUpdateQueryBuilderDsl>(p, VariantUpdateQueryBuilderDsl.Of));
        }

    }
}
