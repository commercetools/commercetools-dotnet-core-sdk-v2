// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> AddressId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addressId")),
            p => new CombinationQueryPredicate<BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, BusinessUnitAddressCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
