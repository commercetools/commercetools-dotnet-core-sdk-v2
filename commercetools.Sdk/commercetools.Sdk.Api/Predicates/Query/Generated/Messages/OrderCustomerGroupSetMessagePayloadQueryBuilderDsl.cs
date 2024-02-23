using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class OrderCustomerGroupSetMessagePayloadQueryBuilderDsl
    {
        public OrderCustomerGroupSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static OrderCustomerGroupSetMessagePayloadQueryBuilderDsl Of()
        {
            return new OrderCustomerGroupSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderCustomerGroupSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderCustomerGroupSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderCustomerGroupSetMessagePayloadQueryBuilderDsl>(p, OrderCustomerGroupSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<OrderCustomerGroupSetMessagePayloadQueryBuilderDsl> CustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomerGroupSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl.Of())),
                OrderCustomerGroupSetMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<OrderCustomerGroupSetMessagePayloadQueryBuilderDsl> OldCustomerGroup(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<OrderCustomerGroupSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldCustomerGroup"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomerGroups.CustomerGroupReferenceQueryBuilderDsl.Of())),
                OrderCustomerGroupSetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
