using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class TermFacetResultQueryBuilderDsl
    {
        public TermFacetResultQueryBuilderDsl()
        {
        }

        public static TermFacetResultQueryBuilderDsl Of()
        {
            return new TermFacetResultQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TermFacetResultQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<TermFacetResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<TermFacetResultQueryBuilderDsl>(p, TermFacetResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TermFacetResultQueryBuilderDsl, string> DataType()
        {
            return new ComparisonPredicateBuilder<TermFacetResultQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("dataType")),
            p => new CombinationQueryPredicate<TermFacetResultQueryBuilderDsl>(p, TermFacetResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TermFacetResultQueryBuilderDsl, long> Missing()
        {
            return new ComparisonPredicateBuilder<TermFacetResultQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("missing")),
            p => new CombinationQueryPredicate<TermFacetResultQueryBuilderDsl>(p, TermFacetResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TermFacetResultQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<TermFacetResultQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<TermFacetResultQueryBuilderDsl>(p, TermFacetResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TermFacetResultQueryBuilderDsl, long> Other()
        {
            return new ComparisonPredicateBuilder<TermFacetResultQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("other")),
            p => new CombinationQueryPredicate<TermFacetResultQueryBuilderDsl>(p, TermFacetResultQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TermFacetResultQueryBuilderDsl> Terms(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.FacetTermQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.FacetTermQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TermFacetResultQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("terms"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.FacetTermQueryBuilderDsl.Of())),
                TermFacetResultQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<TermFacetResultQueryBuilderDsl> Terms()
        {
            return new CollectionPredicateBuilder<TermFacetResultQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("terms")),
                    p => new CombinationQueryPredicate<TermFacetResultQueryBuilderDsl>(p, TermFacetResultQueryBuilderDsl.Of));
        }

    }
}
