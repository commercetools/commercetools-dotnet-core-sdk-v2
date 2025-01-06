// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnitSearches
{

    public partial class BusinessUnitIndexingProgressQueryBuilderDsl
    {
        public BusinessUnitIndexingProgressQueryBuilderDsl()
        {
        }

        public static BusinessUnitIndexingProgressQueryBuilderDsl Of()
        {
            return new BusinessUnitIndexingProgressQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitIndexingProgressQueryBuilderDsl, long> Indexed()
        {
            return new ComparisonPredicateBuilder<BusinessUnitIndexingProgressQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("indexed")),
            p => new CombinationQueryPredicate<BusinessUnitIndexingProgressQueryBuilderDsl>(p, BusinessUnitIndexingProgressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitIndexingProgressQueryBuilderDsl, long> Failed()
        {
            return new ComparisonPredicateBuilder<BusinessUnitIndexingProgressQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("failed")),
            p => new CombinationQueryPredicate<BusinessUnitIndexingProgressQueryBuilderDsl>(p, BusinessUnitIndexingProgressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitIndexingProgressQueryBuilderDsl, long> EstimatedTotal()
        {
            return new ComparisonPredicateBuilder<BusinessUnitIndexingProgressQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("estimatedTotal")),
            p => new CombinationQueryPredicate<BusinessUnitIndexingProgressQueryBuilderDsl>(p, BusinessUnitIndexingProgressQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
