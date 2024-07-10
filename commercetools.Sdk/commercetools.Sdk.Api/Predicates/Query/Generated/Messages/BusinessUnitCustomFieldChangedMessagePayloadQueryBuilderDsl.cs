// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl, string> OldValue()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldValue")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitCustomFieldChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
