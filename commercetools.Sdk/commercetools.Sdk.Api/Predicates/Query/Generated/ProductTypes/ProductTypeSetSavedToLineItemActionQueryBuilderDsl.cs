// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeSetSavedToLineItemActionQueryBuilderDsl
    {
        public ProductTypeSetSavedToLineItemActionQueryBuilderDsl()
        {
        }

        public static ProductTypeSetSavedToLineItemActionQueryBuilderDsl Of()
        {
            return new ProductTypeSetSavedToLineItemActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeSetSavedToLineItemActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeSetSavedToLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeSetSavedToLineItemActionQueryBuilderDsl>(p, ProductTypeSetSavedToLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeSetSavedToLineItemActionQueryBuilderDsl, string> AttributeName()
        {
            return new ComparisonPredicateBuilder<ProductTypeSetSavedToLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeName")),
            p => new CombinationQueryPredicate<ProductTypeSetSavedToLineItemActionQueryBuilderDsl>(p, ProductTypeSetSavedToLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeSetSavedToLineItemActionQueryBuilderDsl, bool> SavedToLineItem()
        {
            return new ComparisonPredicateBuilder<ProductTypeSetSavedToLineItemActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("savedToLineItem")),
            p => new CombinationQueryPredicate<ProductTypeSetSavedToLineItemActionQueryBuilderDsl>(p, ProductTypeSetSavedToLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
