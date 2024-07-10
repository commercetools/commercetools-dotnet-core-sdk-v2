using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class InvalidInputErrorQueryBuilderDsl
    {
        public InvalidInputErrorQueryBuilderDsl()
        {
        }

        public static InvalidInputErrorQueryBuilderDsl Of()
        {
            return new InvalidInputErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InvalidInputErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<InvalidInputErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<InvalidInputErrorQueryBuilderDsl>(p, InvalidInputErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InvalidInputErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<InvalidInputErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<InvalidInputErrorQueryBuilderDsl>(p, InvalidInputErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
