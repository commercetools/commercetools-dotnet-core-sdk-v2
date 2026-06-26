using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantPagedQueryResponseQueryBuilderDsl
    {
        public VariantPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static VariantPagedQueryResponseQueryBuilderDsl Of()
        {
            return new VariantPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<VariantPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<VariantPagedQueryResponseQueryBuilderDsl>(p, VariantPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<VariantPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<VariantPagedQueryResponseQueryBuilderDsl>(p, VariantPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<VariantPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<VariantPagedQueryResponseQueryBuilderDsl>(p, VariantPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<VariantPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<VariantPagedQueryResponseQueryBuilderDsl>(p, VariantPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantQueryBuilderDsl.Of())),
                VariantPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<VariantPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<VariantPagedQueryResponseQueryBuilderDsl>(p, VariantPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
