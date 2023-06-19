using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListAddLineItemActionQueryBuilderDsl
    {
        public MyShoppingListAddLineItemActionQueryBuilderDsl()
        {
        }

        public static MyShoppingListAddLineItemActionQueryBuilderDsl Of()
        {
            return new MyShoppingListAddLineItemActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyShoppingListAddLineItemActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<MyShoppingListAddLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<MyShoppingListAddLineItemActionQueryBuilderDsl>(p, MyShoppingListAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListAddLineItemActionQueryBuilderDsl, string> Sku()
        {
            return new ComparisonPredicateBuilder<MyShoppingListAddLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sku")),
            p => new CombinationQueryPredicate<MyShoppingListAddLineItemActionQueryBuilderDsl>(p, MyShoppingListAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListAddLineItemActionQueryBuilderDsl, string> ProductId()
        {
            return new ComparisonPredicateBuilder<MyShoppingListAddLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productId")),
            p => new CombinationQueryPredicate<MyShoppingListAddLineItemActionQueryBuilderDsl>(p, MyShoppingListAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListAddLineItemActionQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<MyShoppingListAddLineItemActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<MyShoppingListAddLineItemActionQueryBuilderDsl>(p, MyShoppingListAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListAddLineItemActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<MyShoppingListAddLineItemActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<MyShoppingListAddLineItemActionQueryBuilderDsl>(p, MyShoppingListAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyShoppingListAddLineItemActionQueryBuilderDsl, DateTime> AddedAt()
        {
            return new ComparisonPredicateBuilder<MyShoppingListAddLineItemActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedAt")),
            p => new CombinationQueryPredicate<MyShoppingListAddLineItemActionQueryBuilderDsl>(p, MyShoppingListAddLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyShoppingListAddLineItemActionQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListAddLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                MyShoppingListAddLineItemActionQueryBuilderDsl.Of);
        }


    }
}
