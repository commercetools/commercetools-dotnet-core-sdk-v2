using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class HttpDestinationAuthenticationQueryBuilderDsl
    {
        public HttpDestinationAuthenticationQueryBuilderDsl()
        {
        }

        public static HttpDestinationAuthenticationQueryBuilderDsl Of()
        {
            return new HttpDestinationAuthenticationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<HttpDestinationAuthenticationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<HttpDestinationAuthenticationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<HttpDestinationAuthenticationQueryBuilderDsl>(p, HttpDestinationAuthenticationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<HttpDestinationAuthenticationQueryBuilderDsl> AsAuthorizationHeader(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.AuthorizationHeaderAuthenticationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.AuthorizationHeaderAuthenticationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<HttpDestinationAuthenticationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.AuthorizationHeaderAuthenticationQueryBuilderDsl.Of()),
                HttpDestinationAuthenticationQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<HttpDestinationAuthenticationQueryBuilderDsl> AsAzureFunctions(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.AzureFunctionsAuthenticationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.AzureFunctionsAuthenticationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<HttpDestinationAuthenticationQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.AzureFunctionsAuthenticationQueryBuilderDsl.Of()),
                HttpDestinationAuthenticationQueryBuilderDsl.Of);
        }
    }
}
