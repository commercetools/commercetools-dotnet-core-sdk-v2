using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class TextLineItemDraftQueryBuilderDsl
    {
        public TextLineItemDraftQueryBuilderDsl()
        {
        }

        public static TextLineItemDraftQueryBuilderDsl Of()
        {
            return new TextLineItemDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TextLineItemDraftQueryBuilderDsl, DateTime> AddedAt()
        {
            return new ComparisonPredicateBuilder<TextLineItemDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedAt")),
            p => new CombinationQueryPredicate<TextLineItemDraftQueryBuilderDsl>(p, TextLineItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TextLineItemDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TextLineItemDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                TextLineItemDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<TextLineItemDraftQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TextLineItemDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                TextLineItemDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<TextLineItemDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TextLineItemDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                TextLineItemDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<TextLineItemDraftQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<TextLineItemDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<TextLineItemDraftQueryBuilderDsl>(p, TextLineItemDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
