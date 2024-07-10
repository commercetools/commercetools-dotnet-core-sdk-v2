using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderCustomerEmailSetMessagePayloadQueryBuilderDsl
    {
        public OrderCustomerEmailSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderCustomerEmailSetMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderCustomerEmailSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderCustomerEmailSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderCustomerEmailSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderCustomerEmailSetMessagePayloadQueryBuilderDsl>(p, OrderCustomerEmailSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomerEmailSetMessagePayloadQueryBuilderDsl, string> Email()
        {
            return new ComparisonPredicateBuilder<OrderCustomerEmailSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("email")),
            p => new CombinationQueryPredicate<OrderCustomerEmailSetMessagePayloadQueryBuilderDsl>(p, OrderCustomerEmailSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderCustomerEmailSetMessagePayloadQueryBuilderDsl, string> OldEmail()
        {
            return new ComparisonPredicateBuilder<OrderCustomerEmailSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldEmail")),
            p => new CombinationQueryPredicate<OrderCustomerEmailSetMessagePayloadQueryBuilderDsl>(p, OrderCustomerEmailSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
