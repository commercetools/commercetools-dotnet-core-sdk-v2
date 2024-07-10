using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class AuthorizationHeaderAuthenticationQueryBuilderDsl
    {
        public AuthorizationHeaderAuthenticationQueryBuilderDsl()
        {
        }

        public static AuthorizationHeaderAuthenticationQueryBuilderDsl Of()
        {
            return new AuthorizationHeaderAuthenticationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AuthorizationHeaderAuthenticationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AuthorizationHeaderAuthenticationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AuthorizationHeaderAuthenticationQueryBuilderDsl>(p, AuthorizationHeaderAuthenticationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AuthorizationHeaderAuthenticationQueryBuilderDsl, string> HeaderValue()
        {
            return new ComparisonPredicateBuilder<AuthorizationHeaderAuthenticationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("headerValue")),
            p => new CombinationQueryPredicate<AuthorizationHeaderAuthenticationQueryBuilderDsl>(p, AuthorizationHeaderAuthenticationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
