using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class MoneyOverflowErrorQueryBuilderDsl
    {
        public MoneyOverflowErrorQueryBuilderDsl()
        {
        }

        public static MoneyOverflowErrorQueryBuilderDsl Of()
        {
            return new MoneyOverflowErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MoneyOverflowErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<MoneyOverflowErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<MoneyOverflowErrorQueryBuilderDsl>(p, MoneyOverflowErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MoneyOverflowErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<MoneyOverflowErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<MoneyOverflowErrorQueryBuilderDsl>(p, MoneyOverflowErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
