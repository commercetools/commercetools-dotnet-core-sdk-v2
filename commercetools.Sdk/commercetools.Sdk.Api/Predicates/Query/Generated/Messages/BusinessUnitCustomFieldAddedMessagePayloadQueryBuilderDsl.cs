// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, BusinessUnitCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
