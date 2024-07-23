// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyCartChangeLineItemsOrderActionQueryBuilderDsl
    {
        public MyCartChangeLineItemsOrderActionQueryBuilderDsl()
        {
        }

        public static MyCartChangeLineItemsOrderActionQueryBuilderDsl Of()
        {
            return new MyCartChangeLineItemsOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyCartChangeLineItemsOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyCartChangeLineItemsOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyCartChangeLineItemsOrderActionQueryBuilderDsl>(p, MyCartChangeLineItemsOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<MyCartChangeLineItemsOrderActionQueryBuilderDsl, string> LineItemOrder()
        {
            return new ComparableCollectionPredicateBuilder<MyCartChangeLineItemsOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemOrder")),
            p => new CombinationQueryPredicate<MyCartChangeLineItemsOrderActionQueryBuilderDsl>(p, MyCartChangeLineItemsOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
