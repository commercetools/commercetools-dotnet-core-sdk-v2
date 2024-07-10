// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchStringValueQueryBuilderDsl
    {
        public OrderSearchStringValueQueryBuilderDsl()
        {
        }

        public static OrderSearchStringValueQueryBuilderDsl Of()
        {
            return new OrderSearchStringValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSearchStringValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<OrderSearchStringValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<OrderSearchStringValueQueryBuilderDsl>(p, OrderSearchStringValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchStringValueQueryBuilderDsl, long> Boost()
        {
            return new ComparisonPredicateBuilder<OrderSearchStringValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<OrderSearchStringValueQueryBuilderDsl>(p, OrderSearchStringValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchStringValueQueryBuilderDsl, string> CustomType()
        {
            return new ComparisonPredicateBuilder<OrderSearchStringValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customType")),
            p => new CombinationQueryPredicate<OrderSearchStringValueQueryBuilderDsl>(p, OrderSearchStringValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchStringValueQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<OrderSearchStringValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<OrderSearchStringValueQueryBuilderDsl>(p, OrderSearchStringValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchStringValueQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<OrderSearchStringValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<OrderSearchStringValueQueryBuilderDsl>(p, OrderSearchStringValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchStringValueQueryBuilderDsl, bool> CaseInsensitive()
        {
            return new ComparisonPredicateBuilder<OrderSearchStringValueQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("caseInsensitive")),
            p => new CombinationQueryPredicate<OrderSearchStringValueQueryBuilderDsl>(p, OrderSearchStringValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
