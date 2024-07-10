// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitCustomFieldRemovedMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitCustomFieldRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitCustomFieldRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitCustomFieldRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, BusinessUnitCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, BusinessUnitCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
