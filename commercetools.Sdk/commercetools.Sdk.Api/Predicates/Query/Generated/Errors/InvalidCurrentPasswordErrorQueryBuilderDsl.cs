using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class InvalidCurrentPasswordErrorQueryBuilderDsl
    {
        public InvalidCurrentPasswordErrorQueryBuilderDsl()
        {
        }

        public static InvalidCurrentPasswordErrorQueryBuilderDsl Of()
        {
            return new InvalidCurrentPasswordErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InvalidCurrentPasswordErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<InvalidCurrentPasswordErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<InvalidCurrentPasswordErrorQueryBuilderDsl>(p, InvalidCurrentPasswordErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InvalidCurrentPasswordErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<InvalidCurrentPasswordErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<InvalidCurrentPasswordErrorQueryBuilderDsl>(p, InvalidCurrentPasswordErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
