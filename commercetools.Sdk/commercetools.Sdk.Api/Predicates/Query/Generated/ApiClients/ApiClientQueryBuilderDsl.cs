using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApiClients
{

    public partial class ApiClientQueryBuilderDsl
    {
        public ApiClientQueryBuilderDsl()
        {
        }

        public static ApiClientQueryBuilderDsl Of()
        {
            return new ApiClientQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApiClientQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ApiClientQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ApiClientQueryBuilderDsl>(p, ApiClientQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApiClientQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ApiClientQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ApiClientQueryBuilderDsl>(p, ApiClientQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApiClientQueryBuilderDsl, string> Scope()
        {
            return new ComparisonPredicateBuilder<ApiClientQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("scope")),
            p => new CombinationQueryPredicate<ApiClientQueryBuilderDsl>(p, ApiClientQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApiClientQueryBuilderDsl, string> Secret()
        {
            return new ComparisonPredicateBuilder<ApiClientQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("secret")),
            p => new CombinationQueryPredicate<ApiClientQueryBuilderDsl>(p, ApiClientQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApiClientQueryBuilderDsl, Date> LastUsedAt()
        {
            return new ComparisonPredicateBuilder<ApiClientQueryBuilderDsl, Date>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastUsedAt")),
            p => new CombinationQueryPredicate<ApiClientQueryBuilderDsl>(p, ApiClientQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApiClientQueryBuilderDsl, DateTime> DeleteAt()
        {
            return new ComparisonPredicateBuilder<ApiClientQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deleteAt")),
            p => new CombinationQueryPredicate<ApiClientQueryBuilderDsl>(p, ApiClientQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApiClientQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ApiClientQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ApiClientQueryBuilderDsl>(p, ApiClientQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApiClientQueryBuilderDsl, long> AccessTokenValiditySeconds()
        {
            return new ComparisonPredicateBuilder<ApiClientQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("accessTokenValiditySeconds")),
            p => new CombinationQueryPredicate<ApiClientQueryBuilderDsl>(p, ApiClientQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApiClientQueryBuilderDsl, long> RefreshTokenValiditySeconds()
        {
            return new ComparisonPredicateBuilder<ApiClientQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("refreshTokenValiditySeconds")),
            p => new CombinationQueryPredicate<ApiClientQueryBuilderDsl>(p, ApiClientQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
