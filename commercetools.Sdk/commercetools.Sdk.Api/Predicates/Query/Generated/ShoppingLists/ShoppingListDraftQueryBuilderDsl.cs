using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListDraftQueryBuilderDsl
    {
        public ShoppingListDraftQueryBuilderDsl()
        {
        }

        public static ShoppingListDraftQueryBuilderDsl Of()
        {
            return new ShoppingListDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShoppingListDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl> Slug(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("slug"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShoppingListDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl.Of())),
                ShoppingListDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShoppingListDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ShoppingListDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl>(p, ShoppingListDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShoppingListDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShoppingListDraftQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<ShoppingListDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl>(p, ShoppingListDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListDraftQueryBuilderDsl, long> DeleteDaysAfterLastModification()
        {
            return new ComparisonPredicateBuilder<ShoppingListDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deleteDaysAfterLastModification")),
            p => new CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl>(p, ShoppingListDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl> LineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemDraftQueryBuilderDsl.Of())),
                ShoppingListDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ShoppingListDraftQueryBuilderDsl> LineItems()
        {
            return new CollectionPredicateBuilder<ShoppingListDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItems")),
                    p => new CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl>(p, ShoppingListDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl> TextLineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.TextLineItemDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.TextLineItemDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("textLineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.TextLineItemDraftQueryBuilderDsl.Of())),
                ShoppingListDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ShoppingListDraftQueryBuilderDsl> TextLineItems()
        {
            return new CollectionPredicateBuilder<ShoppingListDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItems")),
                    p => new CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl>(p, ShoppingListDraftQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreResourceIdentifierQueryBuilderDsl.Of())),
                ShoppingListDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                ShoppingListDraftQueryBuilderDsl.Of);
        }


    }
}
