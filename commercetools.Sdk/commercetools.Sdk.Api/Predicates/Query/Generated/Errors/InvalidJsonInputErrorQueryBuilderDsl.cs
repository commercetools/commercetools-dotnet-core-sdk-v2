using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class InvalidJsonInputErrorQueryBuilderDsl
    {
        public InvalidJsonInputErrorQueryBuilderDsl()
        {
        }

        public static InvalidJsonInputErrorQueryBuilderDsl Of()
        {
            return new InvalidJsonInputErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InvalidJsonInputErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<InvalidJsonInputErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<InvalidJsonInputErrorQueryBuilderDsl>(p, InvalidJsonInputErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InvalidJsonInputErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<InvalidJsonInputErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<InvalidJsonInputErrorQueryBuilderDsl>(p, InvalidJsonInputErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InvalidJsonInputErrorQueryBuilderDsl, string> DetailedErrorMessage()
        {
            return new ComparisonPredicateBuilder<InvalidJsonInputErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("detailedErrorMessage")),
            p => new CombinationQueryPredicate<InvalidJsonInputErrorQueryBuilderDsl>(p, InvalidJsonInputErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
