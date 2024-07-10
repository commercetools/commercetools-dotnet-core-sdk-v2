// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitChangeStatusActionQueryBuilderDsl
    {
        public BusinessUnitChangeStatusActionQueryBuilderDsl()
        {
        }

        public static BusinessUnitChangeStatusActionQueryBuilderDsl Of()
        {
            return new BusinessUnitChangeStatusActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitChangeStatusActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<BusinessUnitChangeStatusActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<BusinessUnitChangeStatusActionQueryBuilderDsl>(p, BusinessUnitChangeStatusActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitChangeStatusActionQueryBuilderDsl, string> Status()
        {
            return new ComparisonPredicateBuilder<BusinessUnitChangeStatusActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("status")),
            p => new CombinationQueryPredicate<BusinessUnitChangeStatusActionQueryBuilderDsl>(p, BusinessUnitChangeStatusActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
