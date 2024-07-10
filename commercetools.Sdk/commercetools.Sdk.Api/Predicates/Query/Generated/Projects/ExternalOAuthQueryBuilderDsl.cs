using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ExternalOAuthQueryBuilderDsl
    {
        public ExternalOAuthQueryBuilderDsl()
        {
        }

        public static ExternalOAuthQueryBuilderDsl Of()
        {
            return new ExternalOAuthQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExternalOAuthQueryBuilderDsl, string> Url()
        {
            return new ComparisonPredicateBuilder<ExternalOAuthQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("url")),
            p => new CombinationQueryPredicate<ExternalOAuthQueryBuilderDsl>(p, ExternalOAuthQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExternalOAuthQueryBuilderDsl, string> AuthorizationHeader()
        {
            return new ComparisonPredicateBuilder<ExternalOAuthQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("authorizationHeader")),
            p => new CombinationQueryPredicate<ExternalOAuthQueryBuilderDsl>(p, ExternalOAuthQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
