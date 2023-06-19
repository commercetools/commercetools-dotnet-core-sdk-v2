// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductRevertStagedChangesActionQueryBuilderDsl
    {
        public ProductRevertStagedChangesActionQueryBuilderDsl()
        {
        }

        public static ProductRevertStagedChangesActionQueryBuilderDsl Of()
        {
            return new ProductRevertStagedChangesActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductRevertStagedChangesActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductRevertStagedChangesActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductRevertStagedChangesActionQueryBuilderDsl>(p, ProductRevertStagedChangesActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
