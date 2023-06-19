using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionPagedQueryResponseQueryBuilderDsl
    {
        public ExtensionPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static ExtensionPagedQueryResponseQueryBuilderDsl Of()
        {
            return new ExtensionPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ExtensionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ExtensionPagedQueryResponseQueryBuilderDsl>(p, ExtensionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ExtensionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ExtensionPagedQueryResponseQueryBuilderDsl>(p, ExtensionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ExtensionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ExtensionPagedQueryResponseQueryBuilderDsl>(p, ExtensionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<ExtensionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<ExtensionPagedQueryResponseQueryBuilderDsl>(p, ExtensionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionQueryBuilderDsl.Of())),
                ExtensionPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ExtensionPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ExtensionPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ExtensionPagedQueryResponseQueryBuilderDsl>(p, ExtensionPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
