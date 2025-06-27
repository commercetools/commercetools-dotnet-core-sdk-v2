using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountGroups
{

    public partial class DiscountGroupDraftQueryBuilderDsl
    {
        public DiscountGroupDraftQueryBuilderDsl()
        {
        }

        public static DiscountGroupDraftQueryBuilderDsl Of()
        {
            return new DiscountGroupDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<DiscountGroupDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                DiscountGroupDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DiscountGroupDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<DiscountGroupDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<DiscountGroupDraftQueryBuilderDsl>(p, DiscountGroupDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<DiscountGroupDraftQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                DiscountGroupDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<DiscountGroupDraftQueryBuilderDsl, string> SortOrder()
        {
            return new ComparisonPredicateBuilder<DiscountGroupDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sortOrder")),
            p => new CombinationQueryPredicate<DiscountGroupDraftQueryBuilderDsl>(p, DiscountGroupDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
