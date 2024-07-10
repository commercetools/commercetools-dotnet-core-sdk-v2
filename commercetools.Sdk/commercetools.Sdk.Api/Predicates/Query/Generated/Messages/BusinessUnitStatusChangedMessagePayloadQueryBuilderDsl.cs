// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitStatusChangedMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitStatusChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitStatusChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitStatusChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitStatusChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitStatusChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitStatusChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitStatusChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitStatusChangedMessagePayloadQueryBuilderDsl, string> Active()
        {
            return new ComparisonPredicateBuilder<BusinessUnitStatusChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("active")),
            p => new CombinationQueryPredicate<BusinessUnitStatusChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitStatusChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
