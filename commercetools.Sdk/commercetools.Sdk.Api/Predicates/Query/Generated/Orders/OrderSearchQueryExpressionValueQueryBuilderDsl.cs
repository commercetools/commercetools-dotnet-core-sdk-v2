using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSearchQueryExpressionValueQueryBuilderDsl
    {
        public OrderSearchQueryExpressionValueQueryBuilderDsl()
        {
        }

        public static OrderSearchQueryExpressionValueQueryBuilderDsl Of()
        {
            return new OrderSearchQueryExpressionValueQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSearchQueryExpressionValueQueryBuilderDsl, string> Field()
        {
            return new ComparisonPredicateBuilder<OrderSearchQueryExpressionValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("field")),
            p => new CombinationQueryPredicate<OrderSearchQueryExpressionValueQueryBuilderDsl>(p, OrderSearchQueryExpressionValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchQueryExpressionValueQueryBuilderDsl, long> Boost()
        {
            return new ComparisonPredicateBuilder<OrderSearchQueryExpressionValueQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("boost")),
            p => new CombinationQueryPredicate<OrderSearchQueryExpressionValueQueryBuilderDsl>(p, OrderSearchQueryExpressionValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSearchQueryExpressionValueQueryBuilderDsl, string> CustomType()
        {
            return new ComparisonPredicateBuilder<OrderSearchQueryExpressionValueQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("customType")),
            p => new CombinationQueryPredicate<OrderSearchQueryExpressionValueQueryBuilderDsl>(p, OrderSearchQueryExpressionValueQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<OrderSearchQueryExpressionValueQueryBuilderDsl> AsOrderSearchAnyValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchAnyValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchAnyValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchAnyValueQueryBuilderDsl.Of()),
                OrderSearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderSearchQueryExpressionValueQueryBuilderDsl> AsOrderSearchDateRangeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchDateRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchDateRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchDateRangeValueQueryBuilderDsl.Of()),
                OrderSearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderSearchQueryExpressionValueQueryBuilderDsl> AsOrderSearchFullTextValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchFullTextValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchFullTextValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchFullTextValueQueryBuilderDsl.Of()),
                OrderSearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderSearchQueryExpressionValueQueryBuilderDsl> AsOrderSearchLongRangeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchLongRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchLongRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchLongRangeValueQueryBuilderDsl.Of()),
                OrderSearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderSearchQueryExpressionValueQueryBuilderDsl> AsOrderSearchNumberRangeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchNumberRangeValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchNumberRangeValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchNumberRangeValueQueryBuilderDsl.Of()),
                OrderSearchQueryExpressionValueQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<OrderSearchQueryExpressionValueQueryBuilderDsl> AsOrderSearchStringValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchStringValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchStringValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderSearchQueryExpressionValueQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.OrderSearchStringValueQueryBuilderDsl.Of()),
                OrderSearchQueryExpressionValueQueryBuilderDsl.Of);
        }
    }
}
