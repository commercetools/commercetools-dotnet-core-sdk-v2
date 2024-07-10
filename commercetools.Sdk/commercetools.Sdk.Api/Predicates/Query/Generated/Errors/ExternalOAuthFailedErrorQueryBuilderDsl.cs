using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ExternalOAuthFailedErrorQueryBuilderDsl
    {
        public ExternalOAuthFailedErrorQueryBuilderDsl()
        {
        }

        public static ExternalOAuthFailedErrorQueryBuilderDsl Of()
        {
            return new ExternalOAuthFailedErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExternalOAuthFailedErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ExternalOAuthFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ExternalOAuthFailedErrorQueryBuilderDsl>(p, ExternalOAuthFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExternalOAuthFailedErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ExternalOAuthFailedErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ExternalOAuthFailedErrorQueryBuilderDsl>(p, ExternalOAuthFailedErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
