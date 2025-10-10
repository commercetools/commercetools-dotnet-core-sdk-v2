using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Carts
{

    public partial class MergeCartDraftQueryBuilderDsl
    {
        public MergeCartDraftQueryBuilderDsl()
        {
        }

        public static MergeCartDraftQueryBuilderDsl Of()
        {
            return new MergeCartDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<MergeCartDraftQueryBuilderDsl> AnonymousCart(
            Func<commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MergeCartDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("anonymousCart"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Carts.CartResourceIdentifierQueryBuilderDsl.Of())),
                MergeCartDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<MergeCartDraftQueryBuilderDsl, string> MergeMode()
        {
            return new ComparisonPredicateBuilder<MergeCartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("mergeMode")),
            p => new CombinationQueryPredicate<MergeCartDraftQueryBuilderDsl>(p, MergeCartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MergeCartDraftQueryBuilderDsl, bool> UpdateProductData()
        {
            return new ComparisonPredicateBuilder<MergeCartDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("updateProductData")),
            p => new CombinationQueryPredicate<MergeCartDraftQueryBuilderDsl>(p, MergeCartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MergeCartDraftQueryBuilderDsl, string> AnonymousId()
        {
            return new ComparisonPredicateBuilder<MergeCartDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("anonymousId")),
            p => new CombinationQueryPredicate<MergeCartDraftQueryBuilderDsl>(p, MergeCartDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
