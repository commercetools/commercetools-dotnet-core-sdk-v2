using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerDefaultBillingAddressSetMessagePayloadQueryBuilderDsl
    {
        public CustomerDefaultBillingAddressSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerDefaultBillingAddressSetMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerDefaultBillingAddressSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerDefaultBillingAddressSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerDefaultBillingAddressSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerDefaultBillingAddressSetMessagePayloadQueryBuilderDsl>(p, CustomerDefaultBillingAddressSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerDefaultBillingAddressSetMessagePayloadQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerDefaultBillingAddressSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                CustomerDefaultBillingAddressSetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
