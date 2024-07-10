using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StagedQuotes
{

    public partial class StagedQuoteDraftQueryBuilderDsl
    {
        public StagedQuoteDraftQueryBuilderDsl()
        {
        }

        public static StagedQuoteDraftQueryBuilderDsl Of()
        {
            return new StagedQuoteDraftQueryBuilderDsl();
        }

        public CombinationQueryPredicate<StagedQuoteDraftQueryBuilderDsl> QuoteRequest(
            Func<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("quoteRequest"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestResourceIdentifierQueryBuilderDsl.Of())),
                StagedQuoteDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedQuoteDraftQueryBuilderDsl, long> QuoteRequestVersion()
        {
            return new ComparisonPredicateBuilder<StagedQuoteDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quoteRequestVersion")),
            p => new CombinationQueryPredicate<StagedQuoteDraftQueryBuilderDsl>(p, StagedQuoteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteDraftQueryBuilderDsl, bool> QuoteRequestStateToAccepted()
        {
            return new ComparisonPredicateBuilder<StagedQuoteDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("quoteRequestStateToAccepted")),
            p => new CombinationQueryPredicate<StagedQuoteDraftQueryBuilderDsl>(p, StagedQuoteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedQuoteDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<StagedQuoteDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<StagedQuoteDraftQueryBuilderDsl>(p, StagedQuoteDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                StagedQuoteDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StagedQuoteDraftQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                StagedQuoteDraftQueryBuilderDsl.Of);
        }


    }
}
