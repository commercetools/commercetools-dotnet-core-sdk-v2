using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies
{

    public partial class RecurrencePolicyDraftQueryBuilderDsl
    {
        public RecurrencePolicyDraftQueryBuilderDsl()
        {
        }

        public static RecurrencePolicyDraftQueryBuilderDsl Of()
        {
            return new RecurrencePolicyDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurrencePolicyDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<RecurrencePolicyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<RecurrencePolicyDraftQueryBuilderDsl>(p, RecurrencePolicyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<RecurrencePolicyDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicyDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                RecurrencePolicyDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<RecurrencePolicyDraftQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicyDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                RecurrencePolicyDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<RecurrencePolicyDraftQueryBuilderDsl> Schedule(
            Func<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyScheduleDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyScheduleDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<RecurrencePolicyDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("schedule"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.RecurrencePolicies.RecurrencePolicyScheduleDraftQueryBuilderDsl.Of())),
                RecurrencePolicyDraftQueryBuilderDsl.Of);
        }


    }
}
