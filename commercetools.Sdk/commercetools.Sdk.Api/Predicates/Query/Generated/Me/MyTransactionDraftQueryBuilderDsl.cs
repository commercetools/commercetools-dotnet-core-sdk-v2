using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Me
{

    public partial class MyTransactionDraftQueryBuilderDsl
    {
        public MyTransactionDraftQueryBuilderDsl()
        {
        }

        public static MyTransactionDraftQueryBuilderDsl Of()
        {
            return new MyTransactionDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<MyTransactionDraftQueryBuilderDsl, DateTime> Timestamp()
        {
            return new ComparisonPredicateBuilder<MyTransactionDraftQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("timestamp")),
            p => new CombinationQueryPredicate<MyTransactionDraftQueryBuilderDsl>(p, MyTransactionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<MyTransactionDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<MyTransactionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<MyTransactionDraftQueryBuilderDsl>(p, MyTransactionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyTransactionDraftQueryBuilderDsl> Amount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyTransactionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("amount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.MoneyQueryBuilderDsl.Of())),
                MyTransactionDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<MyTransactionDraftQueryBuilderDsl, string> InteractionId()
        {
            return new ComparisonPredicateBuilder<MyTransactionDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interactionId")),
            p => new CombinationQueryPredicate<MyTransactionDraftQueryBuilderDsl>(p, MyTransactionDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<MyTransactionDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<MyTransactionDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                MyTransactionDraftQueryBuilderDsl.Of);
        }


    }
}
