using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyShoppingListDraftQueryBuilderDsl
    {
        public MyShoppingListDraftQueryBuilderDsl()
        {
        }

        public static MyShoppingListDraftQueryBuilderDsl Of()
        {
            return new MyShoppingListDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<MyShoppingListDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                MyShoppingListDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyShoppingListDraftQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                MyShoppingListDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<MyShoppingListDraftQueryBuilderDsl> LineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemDraftQueryBuilderDsl.Of())),
                MyShoppingListDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyShoppingListDraftQueryBuilderDsl> LineItems()
        {
            return new CollectionPredicateBuilder<MyShoppingListDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItems")),
                    p => new CombinationQueryPredicate<MyShoppingListDraftQueryBuilderDsl>(p, MyShoppingListDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<MyShoppingListDraftQueryBuilderDsl> TextLineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.TextLineItemDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.TextLineItemDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("textLineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.TextLineItemDraftQueryBuilderDsl.Of())),
                MyShoppingListDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<MyShoppingListDraftQueryBuilderDsl> TextLineItems()
        {
            return new CollectionPredicateBuilder<MyShoppingListDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItems")),
                    p => new CombinationQueryPredicate<MyShoppingListDraftQueryBuilderDsl>(p, MyShoppingListDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<MyShoppingListDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                MyShoppingListDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<MyShoppingListDraftQueryBuilderDsl, long> DeleteDaysAfterLastModification()
        {
            return new ComparisonPredicateBuilder<MyShoppingListDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deleteDaysAfterLastModification")),
            p => new CombinationQueryPredicate<MyShoppingListDraftQueryBuilderDsl>(p, MyShoppingListDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyShoppingListDraftQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyShoppingListDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                MyShoppingListDraftQueryBuilderDsl.Of);
        }


    }
}
