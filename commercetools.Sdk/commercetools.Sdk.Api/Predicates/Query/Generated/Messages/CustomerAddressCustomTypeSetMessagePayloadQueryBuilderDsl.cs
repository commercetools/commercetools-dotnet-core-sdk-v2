using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl
    {
        public CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl>(p, CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl> CustomFields(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customFields"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl, string> PreviousTypeId()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("previousTypeId")),
            p => new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl>(p, CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl>(p, CustomerAddressCustomTypeSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
