// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchAnyValueQueryBuilderDsl
    {
        public OrderSearchAnyValueQueryBuilderDsl()
        {
        }

        public static OrderSearchAnyValueQueryBuilderDsl Of()
        {
            return new OrderSearchAnyValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSearchAnyValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<OrderSearchAnyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<OrderSearchAnyValueQueryBuilderDsl>(p, OrderSearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchAnyValueQueryBuilderDsl, long> Boost()
        {
            return new ComparisonPredicateBuilder<OrderSearchAnyValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<OrderSearchAnyValueQueryBuilderDsl>(p, OrderSearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchAnyValueQueryBuilderDsl, string> CustomType()
        {
            return new ComparisonPredicateBuilder<OrderSearchAnyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customType")),
            p => new CombinationQueryPredicate<OrderSearchAnyValueQueryBuilderDsl>(p, OrderSearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchAnyValueQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<OrderSearchAnyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<OrderSearchAnyValueQueryBuilderDsl>(p, OrderSearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchAnyValueQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<OrderSearchAnyValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<OrderSearchAnyValueQueryBuilderDsl>(p, OrderSearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchAnyValueQueryBuilderDsl, bool> CaseInsensitive()
        {
            return new ComparisonPredicateBuilder<OrderSearchAnyValueQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("caseInsensitive")),
            p => new CombinationQueryPredicate<OrderSearchAnyValueQueryBuilderDsl>(p, OrderSearchAnyValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
