using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl
    {
        public CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, CustomerAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
