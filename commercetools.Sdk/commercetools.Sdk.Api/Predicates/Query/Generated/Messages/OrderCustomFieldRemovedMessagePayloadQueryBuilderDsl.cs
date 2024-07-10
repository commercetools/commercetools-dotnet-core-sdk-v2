using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderCustomFieldRemovedMessagePayloadQueryBuilderDsl
    {
        public OrderCustomFieldRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderCustomFieldRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderCustomFieldRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, OrderCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<OrderCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<OrderCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, OrderCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
