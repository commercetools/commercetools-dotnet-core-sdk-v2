using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class AssignedProductSelectionPagedQueryResponseQueryBuilderDsl
    {
        public AssignedProductSelectionPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static AssignedProductSelectionPagedQueryResponseQueryBuilderDsl Of()
        {
            return new AssignedProductSelectionPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl>(p, AssignedProductSelectionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl>(p, AssignedProductSelectionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl>(p, AssignedProductSelectionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl>(p, AssignedProductSelectionPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.AssignedProductSelectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.AssignedProductSelectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.AssignedProductSelectionQueryBuilderDsl.Of())),
                AssignedProductSelectionPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<AssignedProductSelectionPagedQueryResponseQueryBuilderDsl>(p, AssignedProductSelectionPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
