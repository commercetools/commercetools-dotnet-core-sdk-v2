// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnitSearches
{

    public partial class BusinessUnitSearchResultQueryBuilderDsl
    {
        public BusinessUnitSearchResultQueryBuilderDsl()
        {
        }

        public static BusinessUnitSearchResultQueryBuilderDsl Of()
        {
            return new BusinessUnitSearchResultQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitSearchResultQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSearchResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<BusinessUnitSearchResultQueryBuilderDsl>(p, BusinessUnitSearchResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitSearchResultQueryBuilderDsl, decimal> Relevance()
        {
            return new ComparisonPredicateBuilder<BusinessUnitSearchResultQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("relevance")),
            p => new CombinationQueryPredicate<BusinessUnitSearchResultQueryBuilderDsl>(p, BusinessUnitSearchResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
