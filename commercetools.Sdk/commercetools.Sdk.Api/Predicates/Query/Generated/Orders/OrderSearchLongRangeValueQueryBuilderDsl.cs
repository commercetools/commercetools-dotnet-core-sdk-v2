// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchLongRangeValueQueryBuilderDsl
    {
        public OrderSearchLongRangeValueQueryBuilderDsl()
        {
        }

        public static OrderSearchLongRangeValueQueryBuilderDsl Of()
        {
            return new OrderSearchLongRangeValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSearchLongRangeValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<OrderSearchLongRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<OrderSearchLongRangeValueQueryBuilderDsl>(p, OrderSearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchLongRangeValueQueryBuilderDsl, long> Boost()
        {
            return new ComparisonPredicateBuilder<OrderSearchLongRangeValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<OrderSearchLongRangeValueQueryBuilderDsl>(p, OrderSearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchLongRangeValueQueryBuilderDsl, string> CustomType()
        {
            return new ComparisonPredicateBuilder<OrderSearchLongRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customType")),
            p => new CombinationQueryPredicate<OrderSearchLongRangeValueQueryBuilderDsl>(p, OrderSearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchLongRangeValueQueryBuilderDsl, long> Gte()
        {
            return new ComparisonPredicateBuilder<OrderSearchLongRangeValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gte")),
            p => new CombinationQueryPredicate<OrderSearchLongRangeValueQueryBuilderDsl>(p, OrderSearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchLongRangeValueQueryBuilderDsl, long> Lte()
        {
            return new ComparisonPredicateBuilder<OrderSearchLongRangeValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lte")),
            p => new CombinationQueryPredicate<OrderSearchLongRangeValueQueryBuilderDsl>(p, OrderSearchLongRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
