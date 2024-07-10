using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListLineItemQueryBuilderDsl
    {
        public ShoppingListLineItemQueryBuilderDsl()
        {
        }

        public static ShoppingListLineItemQueryBuilderDsl Of()
        {
            return new ShoppingListLineItemQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListLineItemQueryBuilderDsl, DateTime> AddedAt()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedAt")),
            p => new CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl>(p, ShoppingListLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                ShoppingListLineItemQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShoppingListLineItemQueryBuilderDsl, DateTime> DeactivatedAt()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("deactivatedAt")),
            p => new CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl>(p, ShoppingListLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListLineItemQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl>(p, ShoppingListLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListLineItemQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl>(p, ShoppingListLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShoppingListLineItemQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShoppingListLineItemQueryBuilderDsl, string> ProductId()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productId")),
            p => new CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl>(p, ShoppingListLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl> ProductType(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productType"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.ProductTypeReferenceQueryBuilderDsl.Of())),
                ShoppingListLineItemQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShoppingListLineItemQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl>(p, ShoppingListLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListLineItemQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl>(p, ShoppingListLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl> Variant(
            Func<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("variant"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Products.ProductVariantQueryBuilderDsl.Of())),
                ShoppingListLineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl> ProductSlug(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productSlug"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ShoppingListLineItemQueryBuilderDsl.Of);
        }


    }
}
