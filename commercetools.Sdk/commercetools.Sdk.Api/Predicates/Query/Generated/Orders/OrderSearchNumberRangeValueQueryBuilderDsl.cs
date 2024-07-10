// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchNumberRangeValueQueryBuilderDsl
    {
        public OrderSearchNumberRangeValueQueryBuilderDsl()
        {
        }

        public static OrderSearchNumberRangeValueQueryBuilderDsl Of()
        {
            return new OrderSearchNumberRangeValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSearchNumberRangeValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<OrderSearchNumberRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<OrderSearchNumberRangeValueQueryBuilderDsl>(p, OrderSearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchNumberRangeValueQueryBuilderDsl, long> Boost()
        {
            return new ComparisonPredicateBuilder<OrderSearchNumberRangeValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<OrderSearchNumberRangeValueQueryBuilderDsl>(p, OrderSearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchNumberRangeValueQueryBuilderDsl, string> CustomType()
        {
            return new ComparisonPredicateBuilder<OrderSearchNumberRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customType")),
            p => new CombinationQueryPredicate<OrderSearchNumberRangeValueQueryBuilderDsl>(p, OrderSearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchNumberRangeValueQueryBuilderDsl, decimal> Gte()
        {
            return new ComparisonPredicateBuilder<OrderSearchNumberRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gte")),
            p => new CombinationQueryPredicate<OrderSearchNumberRangeValueQueryBuilderDsl>(p, OrderSearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchNumberRangeValueQueryBuilderDsl, decimal> Lte()
        {
            return new ComparisonPredicateBuilder<OrderSearchNumberRangeValueQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lte")),
            p => new CombinationQueryPredicate<OrderSearchNumberRangeValueQueryBuilderDsl>(p, OrderSearchNumberRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
