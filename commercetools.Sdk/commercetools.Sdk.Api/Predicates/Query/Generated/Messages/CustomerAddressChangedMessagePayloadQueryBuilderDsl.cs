using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerAddressChangedMessagePayloadQueryBuilderDsl
    {
        public CustomerAddressChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerAddressChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerAddressChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerAddressChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerAddressChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerAddressChangedMessagePayloadQueryBuilderDsl>(p, CustomerAddressChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerAddressChangedMessagePayloadQueryBuilderDsl> Address(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerAddressChangedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("address"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AddressQueryBuilderDsl.Of())),
                CustomerAddressChangedMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparableCollectionPredicateBuilder<CustomerAddressChangedMessagePayloadQueryBuilderDsl, string> AddressRoles()
        {
            return new ComparableCollectionPredicateBuilder<CustomerAddressChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressRoles")),
            p => new CombinationQueryPredicate<CustomerAddressChangedMessagePayloadQueryBuilderDsl>(p, CustomerAddressChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
