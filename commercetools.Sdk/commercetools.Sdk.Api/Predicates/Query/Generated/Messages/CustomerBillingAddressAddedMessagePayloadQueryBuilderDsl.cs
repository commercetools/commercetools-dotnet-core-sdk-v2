using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerBillingAddressAddedMessagePayloadQueryBuilderDsl
    {
        public CustomerBillingAddressAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerBillingAddressAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerBillingAddressAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerBillingAddressAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerBillingAddressAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerBillingAddressAddedMessagePayloadQueryBuilderDsl>(p, CustomerBillingAddressAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerBillingAddressAddedMessagePayloadQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerBillingAddressAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                CustomerBillingAddressAddedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
