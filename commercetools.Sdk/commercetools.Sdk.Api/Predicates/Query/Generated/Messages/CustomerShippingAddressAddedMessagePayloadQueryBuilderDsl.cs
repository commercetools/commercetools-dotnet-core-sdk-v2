using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerShippingAddressAddedMessagePayloadQueryBuilderDsl
    {
        public CustomerShippingAddressAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerShippingAddressAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerShippingAddressAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerShippingAddressAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerShippingAddressAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerShippingAddressAddedMessagePayloadQueryBuilderDsl>(p, CustomerShippingAddressAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerShippingAddressAddedMessagePayloadQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerShippingAddressAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                CustomerShippingAddressAddedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
