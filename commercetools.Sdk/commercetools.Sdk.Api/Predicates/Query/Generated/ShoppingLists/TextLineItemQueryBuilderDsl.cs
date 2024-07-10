using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class TextLineItemQueryBuilderDsl
    {
        public TextLineItemQueryBuilderDsl()
        {
        }

        public static TextLineItemQueryBuilderDsl Of()
        {
            return new TextLineItemQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TextLineItemQueryBuilderDsl, DateTime> AddedAt()
        {
            return new ComparisonPredicateBuilder<TextLineItemQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("addedAt")),
            p => new CombinationQueryPredicate<TextLineItemQueryBuilderDsl>(p, TextLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TextLineItemQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TextLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                TextLineItemQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<TextLineItemQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TextLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                TextLineItemQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<TextLineItemQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<TextLineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<TextLineItemQueryBuilderDsl>(p, TextLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TextLineItemQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<TextLineItemQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<TextLineItemQueryBuilderDsl>(p, TextLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TextLineItemQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TextLineItemQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                TextLineItemQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<TextLineItemQueryBuilderDsl, long> Quantity()
        {
            return new ComparisonPredicateBuilder<TextLineItemQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quantity")),
            p => new CombinationQueryPredicate<TextLineItemQueryBuilderDsl>(p, TextLineItemQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
