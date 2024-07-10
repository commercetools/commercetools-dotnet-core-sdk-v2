using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerAddressRemovedMessagePayloadQueryBuilderDsl
    {
        public CustomerAddressRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerAddressRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerAddressRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerAddressRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerAddressRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerAddressRemovedMessagePayloadQueryBuilderDsl>(p, CustomerAddressRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerAddressRemovedMessagePayloadQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerAddressRemovedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                CustomerAddressRemovedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
