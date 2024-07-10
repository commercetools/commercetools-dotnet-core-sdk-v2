using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class InvalidOperationErrorQueryBuilderDsl
    {
        public InvalidOperationErrorQueryBuilderDsl()
        {
        }

        public static InvalidOperationErrorQueryBuilderDsl Of()
        {
            return new InvalidOperationErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InvalidOperationErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<InvalidOperationErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<InvalidOperationErrorQueryBuilderDsl>(p, InvalidOperationErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InvalidOperationErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<InvalidOperationErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<InvalidOperationErrorQueryBuilderDsl>(p, InvalidOperationErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
