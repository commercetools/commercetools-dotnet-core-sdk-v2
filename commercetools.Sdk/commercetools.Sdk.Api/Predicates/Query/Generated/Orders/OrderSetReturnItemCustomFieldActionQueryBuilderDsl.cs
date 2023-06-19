// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetReturnItemCustomFieldActionQueryBuilderDsl
    {
        public OrderSetReturnItemCustomFieldActionQueryBuilderDsl()
        {
        }

        public static OrderSetReturnItemCustomFieldActionQueryBuilderDsl Of()
        {
            return new OrderSetReturnItemCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetReturnItemCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetReturnItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetReturnItemCustomFieldActionQueryBuilderDsl>(p, OrderSetReturnItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetReturnItemCustomFieldActionQueryBuilderDsl, string> ReturnItemId()
        {
            return new ComparisonPredicateBuilder<OrderSetReturnItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("returnItemId")),
            p => new CombinationQueryPredicate<OrderSetReturnItemCustomFieldActionQueryBuilderDsl>(p, OrderSetReturnItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetReturnItemCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<OrderSetReturnItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<OrderSetReturnItemCustomFieldActionQueryBuilderDsl>(p, OrderSetReturnItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetReturnItemCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<OrderSetReturnItemCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<OrderSetReturnItemCustomFieldActionQueryBuilderDsl>(p, OrderSetReturnItemCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
