using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantProjectionPagedQueryResponseQueryBuilderDsl
    {
        public VariantProjectionPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static VariantProjectionPagedQueryResponseQueryBuilderDsl Of()
        {
            return new VariantProjectionPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantProjectionPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<VariantProjectionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<VariantProjectionPagedQueryResponseQueryBuilderDsl>(p, VariantProjectionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantProjectionPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<VariantProjectionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<VariantProjectionPagedQueryResponseQueryBuilderDsl>(p, VariantProjectionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantProjectionPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<VariantProjectionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<VariantProjectionPagedQueryResponseQueryBuilderDsl>(p, VariantProjectionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantProjectionPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<VariantProjectionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<VariantProjectionPagedQueryResponseQueryBuilderDsl>(p, VariantProjectionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<VariantProjectionPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantProjectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantProjectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantProjectionPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantProjectionQueryBuilderDsl.Of())),
                VariantProjectionPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<VariantProjectionPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<VariantProjectionPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<VariantProjectionPagedQueryResponseQueryBuilderDsl>(p, VariantProjectionPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
