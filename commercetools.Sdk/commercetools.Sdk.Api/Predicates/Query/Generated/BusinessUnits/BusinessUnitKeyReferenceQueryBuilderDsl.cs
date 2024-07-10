// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitKeyReferenceQueryBuilderDsl
    {
        public BusinessUnitKeyReferenceQueryBuilderDsl()
        {
        }

        public static BusinessUnitKeyReferenceQueryBuilderDsl Of()
        {
            return new BusinessUnitKeyReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitKeyReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitKeyReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<BusinessUnitKeyReferenceQueryBuilderDsl>(p, BusinessUnitKeyReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitKeyReferenceQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<BusinessUnitKeyReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<BusinessUnitKeyReferenceQueryBuilderDsl>(p, BusinessUnitKeyReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
