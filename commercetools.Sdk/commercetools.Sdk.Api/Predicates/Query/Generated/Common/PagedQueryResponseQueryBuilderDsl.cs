using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class PagedQueryResponseQueryBuilderDsl
    {
        public PagedQueryResponseQueryBuilderDsl()
        {
        }

        public static PagedQueryResponseQueryBuilderDsl Of()
        {
            return new PagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<PagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<PagedQueryResponseQueryBuilderDsl>(p, PagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<PagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<PagedQueryResponseQueryBuilderDsl>(p, PagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<PagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<PagedQueryResponseQueryBuilderDsl>(p, PagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<PagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<PagedQueryResponseQueryBuilderDsl>(p, PagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.BaseResourceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.BaseResourceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.BaseResourceQueryBuilderDsl.Of())),
                PagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<PagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<PagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<PagedQueryResponseQueryBuilderDsl>(p, PagedQueryResponseQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<PagedQueryResponseQueryBuilderDsl, string> Meta()
        {
            return new ComparisonPredicateBuilder<PagedQueryResponseQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("meta")),
            p => new CombinationQueryPredicate<PagedQueryResponseQueryBuilderDsl>(p, PagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
