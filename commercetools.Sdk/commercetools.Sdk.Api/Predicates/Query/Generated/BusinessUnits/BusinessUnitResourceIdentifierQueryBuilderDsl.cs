// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitResourceIdentifierQueryBuilderDsl
    {
        public BusinessUnitResourceIdentifierQueryBuilderDsl()
        {
        }

        public static BusinessUnitResourceIdentifierQueryBuilderDsl Of()
        {
            return new BusinessUnitResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<BusinessUnitResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<BusinessUnitResourceIdentifierQueryBuilderDsl>(p, BusinessUnitResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<BusinessUnitResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<BusinessUnitResourceIdentifierQueryBuilderDsl>(p, BusinessUnitResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<BusinessUnitResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<BusinessUnitResourceIdentifierQueryBuilderDsl>(p, BusinessUnitResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
