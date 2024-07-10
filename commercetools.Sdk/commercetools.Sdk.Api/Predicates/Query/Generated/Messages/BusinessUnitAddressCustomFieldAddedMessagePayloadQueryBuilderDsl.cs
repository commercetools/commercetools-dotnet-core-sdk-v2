// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
