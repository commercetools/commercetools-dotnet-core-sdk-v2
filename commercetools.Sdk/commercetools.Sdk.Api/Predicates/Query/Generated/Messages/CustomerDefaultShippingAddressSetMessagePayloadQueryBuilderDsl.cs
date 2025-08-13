using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerDefaultShippingAddressSetMessagePayloadQueryBuilderDsl
    {
        public CustomerDefaultShippingAddressSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerDefaultShippingAddressSetMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerDefaultShippingAddressSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerDefaultShippingAddressSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerDefaultShippingAddressSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerDefaultShippingAddressSetMessagePayloadQueryBuilderDsl>(p, CustomerDefaultShippingAddressSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerDefaultShippingAddressSetMessagePayloadQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerDefaultShippingAddressSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                CustomerDefaultShippingAddressSetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
