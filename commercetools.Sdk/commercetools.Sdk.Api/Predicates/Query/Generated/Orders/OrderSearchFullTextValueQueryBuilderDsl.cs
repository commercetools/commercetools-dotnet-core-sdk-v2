using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchFullTextValueQueryBuilderDsl
    {
        public OrderSearchFullTextValueQueryBuilderDsl()
        {
        }

        public static OrderSearchFullTextValueQueryBuilderDsl Of()
        {
            return new OrderSearchFullTextValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSearchFullTextValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<OrderSearchFullTextValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<OrderSearchFullTextValueQueryBuilderDsl>(p, OrderSearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchFullTextValueQueryBuilderDsl, long> Boost()
        {
            return new ComparisonPredicateBuilder<OrderSearchFullTextValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<OrderSearchFullTextValueQueryBuilderDsl>(p, OrderSearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchFullTextValueQueryBuilderDsl, string> CustomType()
        {
            return new ComparisonPredicateBuilder<OrderSearchFullTextValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customType")),
            p => new CombinationQueryPredicate<OrderSearchFullTextValueQueryBuilderDsl>(p, OrderSearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchFullTextValueQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<OrderSearchFullTextValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<OrderSearchFullTextValueQueryBuilderDsl>(p, OrderSearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchFullTextValueQueryBuilderDsl, string> Language()
        {
            return new ComparisonPredicateBuilder<OrderSearchFullTextValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("language")),
            p => new CombinationQueryPredicate<OrderSearchFullTextValueQueryBuilderDsl>(p, OrderSearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchFullTextValueQueryBuilderDsl, string> MustMatch()
        {
            return new ComparisonPredicateBuilder<OrderSearchFullTextValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mustMatch")),
            p => new CombinationQueryPredicate<OrderSearchFullTextValueQueryBuilderDsl>(p, OrderSearchFullTextValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
