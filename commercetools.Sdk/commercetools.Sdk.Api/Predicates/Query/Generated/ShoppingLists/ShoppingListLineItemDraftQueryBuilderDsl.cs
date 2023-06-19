using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListLineItemDraftQueryBuilderDsl
    {
        public ShoppingListLineItemDraftQueryBuilderDsl()
        {
        }

        public static ShoppingListLineItemDraftQueryBuilderDsl Of()
        {
            return new ShoppingListLineItemDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListLineItemDraftQueryBuilderDsl, string> ProductId()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productId")),
            p => new CombinationQueryPredicate<ShoppingListLineItemDraftQueryBuilderDsl>(p, ShoppingListLineItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListLineItemDraftQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ShoppingListLineItemDraftQueryBuilderDsl>(p, ShoppingListLineItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListLineItemDraftQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ShoppingListLineItemDraftQueryBuilderDsl>(p, ShoppingListLineItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListLineItemDraftQueryBuilderDsl, DateTime> AddedAt()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedAt")),
            p => new CombinationQueryPredicate<ShoppingListLineItemDraftQueryBuilderDsl>(p, ShoppingListLineItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListLineItemDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListLineItemDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                ShoppingListLineItemDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShoppingListLineItemDraftQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<ShoppingListLineItemDraftQueryBuilderDsl>(p, ShoppingListLineItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
