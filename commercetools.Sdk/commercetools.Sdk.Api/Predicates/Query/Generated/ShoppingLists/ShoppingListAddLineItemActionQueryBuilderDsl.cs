using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListAddLineItemActionQueryBuilderDsl
    {
        public ShoppingListAddLineItemActionQueryBuilderDsl()
        {
        }

        public static ShoppingListAddLineItemActionQueryBuilderDsl Of()
        {
            return new ShoppingListAddLineItemActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListAddLineItemActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListAddLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListAddLineItemActionQueryBuilderDsl>(p, ShoppingListAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListAddLineItemActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ShoppingListAddLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ShoppingListAddLineItemActionQueryBuilderDsl>(p, ShoppingListAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListAddLineItemActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<ShoppingListAddLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<ShoppingListAddLineItemActionQueryBuilderDsl>(p, ShoppingListAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListAddLineItemActionQueryBuilderDsl, string> ProductId()
        {
            return new ComparisonPredicateBuilder<ShoppingListAddLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productId")),
            p => new CombinationQueryPredicate<ShoppingListAddLineItemActionQueryBuilderDsl>(p, ShoppingListAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListAddLineItemActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ShoppingListAddLineItemActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ShoppingListAddLineItemActionQueryBuilderDsl>(p, ShoppingListAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListAddLineItemActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<ShoppingListAddLineItemActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<ShoppingListAddLineItemActionQueryBuilderDsl>(p, ShoppingListAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListAddLineItemActionQueryBuilderDsl, DateTime> AddedAt()
        {
            return new ComparisonPredicateBuilder<ShoppingListAddLineItemActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedAt")),
            p => new CombinationQueryPredicate<ShoppingListAddLineItemActionQueryBuilderDsl>(p, ShoppingListAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListAddLineItemActionQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListAddLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                ShoppingListAddLineItemActionQueryBuilderDsl.Of);
        }


    }
}
