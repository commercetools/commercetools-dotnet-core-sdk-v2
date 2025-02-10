using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListQueryBuilderDsl
    {
        public ShoppingListQueryBuilderDsl()
        {
        }

        public static ShoppingListQueryBuilderDsl Of()
        {
            return new ShoppingListQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ShoppingListQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(p, ShoppingListQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ShoppingListQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(p, ShoppingListQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ShoppingListQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(p, ShoppingListQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ShoppingListQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(p, ShoppingListQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShoppingListQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShoppingListQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ShoppingListQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(p, ShoppingListQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerReferenceQueryBuilderDsl.Of())),
                ShoppingListQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShoppingListQueryBuilderDsl> Slug(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("slug"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShoppingListQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShoppingListQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShoppingListQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShoppingListQueryBuilderDsl> LineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemQueryBuilderDsl.Of())),
                ShoppingListQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ShoppingListQueryBuilderDsl> LineItems()
        {
            return new CollectionPredicateBuilder<ShoppingListQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItems")),
                    p => new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(p, ShoppingListQueryBuilderDsl.Of));
        }
        public CombinationQueryPredicate<ShoppingListQueryBuilderDsl> TextLineItems(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.TextLineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.TextLineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("textLineItems"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.TextLineItemQueryBuilderDsl.Of())),
                ShoppingListQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ShoppingListQueryBuilderDsl> TextLineItems()
        {
            return new CollectionPredicateBuilder<ShoppingListQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("textLineItems")),
                    p => new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(p, ShoppingListQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ShoppingListQueryBuilderDsl, long> DeleteDaysAfterLastModification()
        {
            return new ComparisonPredicateBuilder<ShoppingListQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deleteDaysAfterLastModification")),
            p => new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(p, ShoppingListQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<ShoppingListQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(p, ShoppingListQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListQueryBuilderDsl> Store(
            Func<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("store"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Stores.StoreKeyReferenceQueryBuilderDsl.Of())),
                ShoppingListQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShoppingListQueryBuilderDsl> BusinessUnit(
            Func<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("businessUnit"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.BusinessUnits.BusinessUnitKeyReferenceQueryBuilderDsl.Of())),
                ShoppingListQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShoppingListQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                ShoppingListQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShoppingListQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ShoppingListQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShoppingListQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ShoppingListQueryBuilderDsl.Of);
        }


    }
}
