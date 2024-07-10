using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl
    {
        public CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl>(p, CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl, string> PreviousTypeId()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("previousTypeId")),
            p => new CombinationQueryPredicate<CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl>(p, CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl>(p, CustomerAddressCustomTypeRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
