using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnitSearches
{

    public partial class BusinessUnitPagedSearchResponseQueryBuilderDsl
    {
        public BusinessUnitPagedSearchResponseQueryBuilderDsl()
        {
        }

        public static BusinessUnitPagedSearchResponseQueryBuilderDsl Of()
        {
            return new BusinessUnitPagedSearchResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitPagedSearchResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<BusinessUnitPagedSearchResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<BusinessUnitPagedSearchResponseQueryBuilderDsl>(p, BusinessUnitPagedSearchResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitPagedSearchResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<BusinessUnitPagedSearchResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<BusinessUnitPagedSearchResponseQueryBuilderDsl>(p, BusinessUnitPagedSearchResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitPagedSearchResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<BusinessUnitPagedSearchResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<BusinessUnitPagedSearchResponseQueryBuilderDsl>(p, BusinessUnitPagedSearchResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitPagedSearchResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnitSearches.BusinessUnitSearchResultQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnitSearches.BusinessUnitSearchResultQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitPagedSearchResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnitSearches.BusinessUnitSearchResultQueryBuilderDsl.Of())),
                BusinessUnitPagedSearchResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitPagedSearchResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<BusinessUnitPagedSearchResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<BusinessUnitPagedSearchResponseQueryBuilderDsl>(p, BusinessUnitPagedSearchResponseQueryBuilderDsl.Of));
        }

    }
}
