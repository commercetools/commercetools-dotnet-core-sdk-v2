// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetParcelCustomFieldActionQueryBuilderDsl
    {
        public OrderSetParcelCustomFieldActionQueryBuilderDsl()
        {
        }

        public static OrderSetParcelCustomFieldActionQueryBuilderDsl Of()
        {
            return new OrderSetParcelCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetParcelCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetParcelCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetParcelCustomFieldActionQueryBuilderDsl>(p, OrderSetParcelCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetParcelCustomFieldActionQueryBuilderDsl, string> ParcelId()
        {
            return new ComparisonPredicateBuilder<OrderSetParcelCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelId")),
            p => new CombinationQueryPredicate<OrderSetParcelCustomFieldActionQueryBuilderDsl>(p, OrderSetParcelCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetParcelCustomFieldActionQueryBuilderDsl, string> ParcelKey()
        {
            return new ComparisonPredicateBuilder<OrderSetParcelCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("parcelKey")),
            p => new CombinationQueryPredicate<OrderSetParcelCustomFieldActionQueryBuilderDsl>(p, OrderSetParcelCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetParcelCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<OrderSetParcelCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<OrderSetParcelCustomFieldActionQueryBuilderDsl>(p, OrderSetParcelCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetParcelCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<OrderSetParcelCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<OrderSetParcelCustomFieldActionQueryBuilderDsl>(p, OrderSetParcelCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
