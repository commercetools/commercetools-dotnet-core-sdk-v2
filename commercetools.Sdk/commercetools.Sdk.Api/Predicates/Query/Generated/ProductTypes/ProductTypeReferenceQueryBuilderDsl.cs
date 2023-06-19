using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeReferenceQueryBuilderDsl
    {
        public ProductTypeReferenceQueryBuilderDsl()
        {
        }

        public static ProductTypeReferenceQueryBuilderDsl Of()
        {
            return new ProductTypeReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ProductTypeReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ProductTypeReferenceQueryBuilderDsl>(p, ProductTypeReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ProductTypeReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ProductTypeReferenceQueryBuilderDsl>(p, ProductTypeReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTypeReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeQueryBuilderDsl.Of())),
                ProductTypeReferenceQueryBuilderDsl.Of);
        }


    }
}
