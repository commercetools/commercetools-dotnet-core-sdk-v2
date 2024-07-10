using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.BusinessUnits
{

    public partial class BusinessUnitPagedQueryResponseQueryBuilderDsl
    {
        public BusinessUnitPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static BusinessUnitPagedQueryResponseQueryBuilderDsl Of()
        {
            return new BusinessUnitPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<BusinessUnitPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<BusinessUnitPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<BusinessUnitPagedQueryResponseQueryBuilderDsl>(p, BusinessUnitPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<BusinessUnitPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<BusinessUnitPagedQueryResponseQueryBuilderDsl>(p, BusinessUnitPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<BusinessUnitPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<BusinessUnitPagedQueryResponseQueryBuilderDsl>(p, BusinessUnitPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<BusinessUnitPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<BusinessUnitPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<BusinessUnitPagedQueryResponseQueryBuilderDsl>(p, BusinessUnitPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<BusinessUnitPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<BusinessUnitPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitQueryBuilderDsl.Of())),
                BusinessUnitPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<BusinessUnitPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<BusinessUnitPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<BusinessUnitPagedQueryResponseQueryBuilderDsl>(p, BusinessUnitPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
