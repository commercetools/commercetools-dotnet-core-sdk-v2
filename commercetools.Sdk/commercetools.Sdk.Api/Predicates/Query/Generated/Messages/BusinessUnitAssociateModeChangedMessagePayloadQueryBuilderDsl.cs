// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl
    {
        public BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl()
        {
        }

        public static BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl Of()
        {
            return new BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl, string> AssociateMode()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associateMode")),
            p => new CombinationQueryPredicate<BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl, string> OldAssociateMode()
        {
            return new ComparisonPredicateBuilder<BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldAssociateMode")),
            p => new CombinationQueryPredicate<BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl>(p, BusinessUnitAssociateModeChangedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
