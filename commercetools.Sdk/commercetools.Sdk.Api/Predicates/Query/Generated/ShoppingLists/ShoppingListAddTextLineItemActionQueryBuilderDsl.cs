using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListAddTextLineItemActionQueryBuilderDsl
    {
        public ShoppingListAddTextLineItemActionQueryBuilderDsl()
        {
        }

        public static ShoppingListAddTextLineItemActionQueryBuilderDsl Of()
        {
            return new ShoppingListAddTextLineItemActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListAddTextLineItemActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShoppingListAddTextLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShoppingListAddTextLineItemActionQueryBuilderDsl>(p, ShoppingListAddTextLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListAddTextLineItemActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListAddTextLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShoppingListAddTextLineItemActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShoppingListAddTextLineItemActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ShoppingListAddTextLineItemActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ShoppingListAddTextLineItemActionQueryBuilderDsl>(p, ShoppingListAddTextLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListAddTextLineItemActionQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListAddTextLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShoppingListAddTextLineItemActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShoppingListAddTextLineItemActionQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<ShoppingListAddTextLineItemActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<ShoppingListAddTextLineItemActionQueryBuilderDsl>(p, ShoppingListAddTextLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListAddTextLineItemActionQueryBuilderDsl, DateTime> AddedAt()
        {
            return new ComparisonPredicateBuilder<ShoppingListAddTextLineItemActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedAt")),
            p => new CombinationQueryPredicate<ShoppingListAddTextLineItemActionQueryBuilderDsl>(p, ShoppingListAddTextLineItemActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListAddTextLineItemActionQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListAddTextLineItemActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                ShoppingListAddTextLineItemActionQueryBuilderDsl.Of);
        }


    }
}
