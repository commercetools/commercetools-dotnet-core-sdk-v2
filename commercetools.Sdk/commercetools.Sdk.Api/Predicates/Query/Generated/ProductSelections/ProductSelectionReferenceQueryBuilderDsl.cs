using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductSelectionReferenceQueryBuilderDsl
    {
        public ProductSelectionReferenceQueryBuilderDsl()
        {
        }

        public static ProductSelectionReferenceQueryBuilderDsl Of()
        {
            return new ProductSelectionReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSelectionReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ProductSelectionReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ProductSelectionReferenceQueryBuilderDsl>(p, ProductSelectionReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSelectionReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductSelectionReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductSelectionReferenceQueryBuilderDsl>(p, ProductSelectionReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSelectionReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionQueryBuilderDsl.Of())),
                ProductSelectionReferenceQueryBuilderDsl.Of);
        }


    }
}
