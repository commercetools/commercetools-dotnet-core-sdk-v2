// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitChangeAssociateModeActionQueryBuilderDsl
    {
        public BusinessUnitChangeAssociateModeActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitChangeAssociateModeActionQueryBuilderDsl Of()
        {
            return new BusinessUnitChangeAssociateModeActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitChangeAssociateModeActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitChangeAssociateModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitChangeAssociateModeActionQueryBuilderDsl>(p, BusinessUnitChangeAssociateModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitChangeAssociateModeActionQueryBuilderDsl, string> AssociateMode()
        {
            return new ComparisonPredicateBuilder<BusinessUnitChangeAssociateModeActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("associateMode")),
            p => new CombinationQueryPredicate<BusinessUnitChangeAssociateModeActionQueryBuilderDsl>(p, BusinessUnitChangeAssociateModeActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
