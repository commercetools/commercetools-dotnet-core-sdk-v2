using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ApiClients
{

    public partial class ApiClientDraftQueryBuilderDsl
    {
        public ApiClientDraftQueryBuilderDsl()
        {
        }

        public static ApiClientDraftQueryBuilderDsl Of()
        {
            return new ApiClientDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ApiClientDraftQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ApiClientDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ApiClientDraftQueryBuilderDsl>(p, ApiClientDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApiClientDraftQueryBuilderDsl, string> Scope()
        {
            return new ComparisonPredicateBuilder<ApiClientDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("scope")),
            p => new CombinationQueryPredicate<ApiClientDraftQueryBuilderDsl>(p, ApiClientDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApiClientDraftQueryBuilderDsl, long> DeleteDaysAfterCreation()
        {
            return new ComparisonPredicateBuilder<ApiClientDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deleteDaysAfterCreation")),
            p => new CombinationQueryPredicate<ApiClientDraftQueryBuilderDsl>(p, ApiClientDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApiClientDraftQueryBuilderDsl, long> AccessTokenValiditySeconds()
        {
            return new ComparisonPredicateBuilder<ApiClientDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("accessTokenValiditySeconds")),
            p => new CombinationQueryPredicate<ApiClientDraftQueryBuilderDsl>(p, ApiClientDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ApiClientDraftQueryBuilderDsl, long> RefreshTokenValiditySeconds()
        {
            return new ComparisonPredicateBuilder<ApiClientDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("refreshTokenValiditySeconds")),
            p => new CombinationQueryPredicate<ApiClientDraftQueryBuilderDsl>(p, ApiClientDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
