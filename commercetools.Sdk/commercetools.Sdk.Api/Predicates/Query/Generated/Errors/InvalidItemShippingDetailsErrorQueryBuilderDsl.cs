using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class InvalidItemShippingDetailsErrorQueryBuilderDsl
    {
        public InvalidItemShippingDetailsErrorQueryBuilderDsl()
        {
        }

        public static InvalidItemShippingDetailsErrorQueryBuilderDsl Of()
        {
            return new InvalidItemShippingDetailsErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<InvalidItemShippingDetailsErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<InvalidItemShippingDetailsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<InvalidItemShippingDetailsErrorQueryBuilderDsl>(p, InvalidItemShippingDetailsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InvalidItemShippingDetailsErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<InvalidItemShippingDetailsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<InvalidItemShippingDetailsErrorQueryBuilderDsl>(p, InvalidItemShippingDetailsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InvalidItemShippingDetailsErrorQueryBuilderDsl, string> Subject()
        {
            return new ComparisonPredicateBuilder<InvalidItemShippingDetailsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("subject")),
            p => new CombinationQueryPredicate<InvalidItemShippingDetailsErrorQueryBuilderDsl>(p, InvalidItemShippingDetailsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<InvalidItemShippingDetailsErrorQueryBuilderDsl, string> ItemId()
        {
            return new ComparisonPredicateBuilder<InvalidItemShippingDetailsErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("itemId")),
            p => new CombinationQueryPredicate<InvalidItemShippingDetailsErrorQueryBuilderDsl>(p, InvalidItemShippingDetailsErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
