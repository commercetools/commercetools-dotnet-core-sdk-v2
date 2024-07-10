using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchDateRangeValueQueryBuilderDsl
    {
        public OrderSearchDateRangeValueQueryBuilderDsl()
        {
        }

        public static OrderSearchDateRangeValueQueryBuilderDsl Of()
        {
            return new OrderSearchDateRangeValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSearchDateRangeValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<OrderSearchDateRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<OrderSearchDateRangeValueQueryBuilderDsl>(p, OrderSearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchDateRangeValueQueryBuilderDsl, long> Boost()
        {
            return new ComparisonPredicateBuilder<OrderSearchDateRangeValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<OrderSearchDateRangeValueQueryBuilderDsl>(p, OrderSearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchDateRangeValueQueryBuilderDsl, string> CustomType()
        {
            return new ComparisonPredicateBuilder<OrderSearchDateRangeValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customType")),
            p => new CombinationQueryPredicate<OrderSearchDateRangeValueQueryBuilderDsl>(p, OrderSearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchDateRangeValueQueryBuilderDsl, DateTime> Gte()
        {
            return new ComparisonPredicateBuilder<OrderSearchDateRangeValueQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("gte")),
            p => new CombinationQueryPredicate<OrderSearchDateRangeValueQueryBuilderDsl>(p, OrderSearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchDateRangeValueQueryBuilderDsl, DateTime> Lte()
        {
            return new ComparisonPredicateBuilder<OrderSearchDateRangeValueQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lte")),
            p => new CombinationQueryPredicate<OrderSearchDateRangeValueQueryBuilderDsl>(p, OrderSearchDateRangeValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
