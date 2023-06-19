using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Quotes
{

    public partial class QuoteDraftQueryBuilderDsl
    {
        public QuoteDraftQueryBuilderDsl()
        {
        }

        public static QuoteDraftQueryBuilderDsl Of()
        {
            return new QuoteDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<QuoteDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<QuoteDraftQueryBuilderDsl>(p, QuoteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteDraftQueryBuilderDsl> StagedQuote(
            Func<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("stagedQuote"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteResourceIdentifierQueryBuilderDsl.Of())),
                QuoteDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteDraftQueryBuilderDsl, long> StagedQuoteVersion()
        {
            return new ComparisonPredicateBuilder<QuoteDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stagedQuoteVersion")),
            p => new CombinationQueryPredicate<QuoteDraftQueryBuilderDsl>(p, QuoteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<QuoteDraftQueryBuilderDsl, bool> StagedQuoteStateToSent()
        {
            return new ComparisonPredicateBuilder<QuoteDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("stagedQuoteStateToSent")),
            p => new CombinationQueryPredicate<QuoteDraftQueryBuilderDsl>(p, QuoteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteDraftQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                QuoteDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                QuoteDraftQueryBuilderDsl.Of);
        }


    }
}
