using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApiClients
{

    public partial class ApiClientPagedQueryResponseQueryBuilderDsl
    {
        public ApiClientPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static ApiClientPagedQueryResponseQueryBuilderDsl Of()
        {
            return new ApiClientPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApiClientPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ApiClientPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ApiClientPagedQueryResponseQueryBuilderDsl>(p, ApiClientPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApiClientPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ApiClientPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ApiClientPagedQueryResponseQueryBuilderDsl>(p, ApiClientPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApiClientPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ApiClientPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ApiClientPagedQueryResponseQueryBuilderDsl>(p, ApiClientPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApiClientPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<ApiClientPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<ApiClientPagedQueryResponseQueryBuilderDsl>(p, ApiClientPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ApiClientPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.ApiClients.ApiClientQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ApiClients.ApiClientQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ApiClientPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ApiClients.ApiClientQueryBuilderDsl.Of())),
                ApiClientPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ApiClientPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ApiClientPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ApiClientPagedQueryResponseQueryBuilderDsl>(p, ApiClientPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
