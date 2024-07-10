using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartChangeLineItemQuantityActionQueryBuilderDsl
    {
        public MyCartChangeLineItemQuantityActionQueryBuilderDsl()
        {
        }

        public static MyCartChangeLineItemQuantityActionQueryBuilderDsl Of()
        {
            return new MyCartChangeLineItemQuantityActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartChangeLineItemQuantityActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartChangeLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartChangeLineItemQuantityActionQueryBuilderDsl>(p, MyCartChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartChangeLineItemQuantityActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<MyCartChangeLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<MyCartChangeLineItemQuantityActionQueryBuilderDsl>(p, MyCartChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartChangeLineItemQuantityActionQueryBuilderDsl, string> LineItemKey()
        {
            return new ComparisonPredicateBuilder<MyCartChangeLineItemQuantityActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemKey")),
            p => new CombinationQueryPredicate<MyCartChangeLineItemQuantityActionQueryBuilderDsl>(p, MyCartChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyCartChangeLineItemQuantityActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<MyCartChangeLineItemQuantityActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<MyCartChangeLineItemQuantityActionQueryBuilderDsl>(p, MyCartChangeLineItemQuantityActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
