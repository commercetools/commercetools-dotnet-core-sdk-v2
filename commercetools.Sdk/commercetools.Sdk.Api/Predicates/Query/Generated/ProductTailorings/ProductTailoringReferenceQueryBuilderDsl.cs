using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringReferenceQueryBuilderDsl
    {
        public ProductTailoringReferenceQueryBuilderDsl()
        {
        }

        public static ProductTailoringReferenceQueryBuilderDsl Of()
        {
            return new ProductTailoringReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ProductTailoringReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ProductTailoringReferenceQueryBuilderDsl>(p, ProductTailoringReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTailoringReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductTailoringReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductTailoringReferenceQueryBuilderDsl>(p, ProductTailoringReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTailorings.ProductTailoringQueryBuilderDsl.Of())),
                ProductTailoringReferenceQueryBuilderDsl.Of);
        }


    }
}
