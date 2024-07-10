using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ProductAssignmentMissingErrorQueryBuilderDsl
    {
        public ProductAssignmentMissingErrorQueryBuilderDsl()
        {
        }

        public static ProductAssignmentMissingErrorQueryBuilderDsl Of()
        {
            return new ProductAssignmentMissingErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductAssignmentMissingErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ProductAssignmentMissingErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ProductAssignmentMissingErrorQueryBuilderDsl>(p, ProductAssignmentMissingErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductAssignmentMissingErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ProductAssignmentMissingErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ProductAssignmentMissingErrorQueryBuilderDsl>(p, ProductAssignmentMissingErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductAssignmentMissingErrorQueryBuilderDsl> Product(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductAssignmentMissingErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("product"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductReferenceQueryBuilderDsl.Of())),
                ProductAssignmentMissingErrorQueryBuilderDsl.Of);
        }


    }
}
