// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl
    {
        public CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, CustomerAddressCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
