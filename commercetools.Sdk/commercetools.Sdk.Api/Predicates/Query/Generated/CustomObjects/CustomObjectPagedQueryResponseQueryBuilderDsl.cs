using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomObjects
{

    public partial class CustomObjectPagedQueryResponseQueryBuilderDsl
    {
        public CustomObjectPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static CustomObjectPagedQueryResponseQueryBuilderDsl Of()
        {
            return new CustomObjectPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomObjectPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<CustomObjectPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<CustomObjectPagedQueryResponseQueryBuilderDsl>(p, CustomObjectPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomObjectPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<CustomObjectPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<CustomObjectPagedQueryResponseQueryBuilderDsl>(p, CustomObjectPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomObjectPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<CustomObjectPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<CustomObjectPagedQueryResponseQueryBuilderDsl>(p, CustomObjectPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomObjectPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<CustomObjectPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<CustomObjectPagedQueryResponseQueryBuilderDsl>(p, CustomObjectPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomObjectPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomObjects.CustomObjectQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomObjects.CustomObjectQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomObjectPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomObjects.CustomObjectQueryBuilderDsl.Of())),
                CustomObjectPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<CustomObjectPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<CustomObjectPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<CustomObjectPagedQueryResponseQueryBuilderDsl>(p, CustomObjectPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
