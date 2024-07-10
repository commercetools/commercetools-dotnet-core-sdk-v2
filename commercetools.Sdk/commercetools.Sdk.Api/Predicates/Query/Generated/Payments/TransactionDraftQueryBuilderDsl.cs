using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class TransactionDraftQueryBuilderDsl
    {
        public TransactionDraftQueryBuilderDsl()
        {
        }

        public static TransactionDraftQueryBuilderDsl Of()
        {
            return new TransactionDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TransactionDraftQueryBuilderDsl, DateTime> Timestamp()
        {
            return new ComparisonPredicateBuilder<TransactionDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("timestamp")),
            p => new CombinationQueryPredicate<TransactionDraftQueryBuilderDsl>(p, TransactionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TransactionDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<TransactionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<TransactionDraftQueryBuilderDsl>(p, TransactionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TransactionDraftQueryBuilderDsl> Amount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TransactionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("amount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                TransactionDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<TransactionDraftQueryBuilderDsl, string> InteractionId()
        {
            return new ComparisonPredicateBuilder<TransactionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interactionId")),
            p => new CombinationQueryPredicate<TransactionDraftQueryBuilderDsl>(p, TransactionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TransactionDraftQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<TransactionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<TransactionDraftQueryBuilderDsl>(p, TransactionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TransactionDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TransactionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                TransactionDraftQueryBuilderDsl.Of);
        }


    }
}
