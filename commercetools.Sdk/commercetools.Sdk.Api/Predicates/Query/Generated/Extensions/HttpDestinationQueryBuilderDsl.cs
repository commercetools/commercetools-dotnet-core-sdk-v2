using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class HttpDestinationQueryBuilderDsl
    {
        public HttpDestinationQueryBuilderDsl()
        {
        }

        public static HttpDestinationQueryBuilderDsl Of()
        {
            return new HttpDestinationQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<HttpDestinationQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<HttpDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<HttpDestinationQueryBuilderDsl>(p, HttpDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<HttpDestinationQueryBuilderDsl, string> Url()
        {
            return new ComparisonPredicateBuilder<HttpDestinationQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("url")),
            p => new CombinationQueryPredicate<HttpDestinationQueryBuilderDsl>(p, HttpDestinationQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<HttpDestinationQueryBuilderDsl> Authentication(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.HttpDestinationAuthenticationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.HttpDestinationAuthenticationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<HttpDestinationQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("authentication"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.HttpDestinationAuthenticationQueryBuilderDsl.Of())),
                HttpDestinationQueryBuilderDsl.Of);
        }


    }
}
