using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class TransactionQueryBuilderDsl
    {
        public TransactionQueryBuilderDsl()
        {
        }

        public static TransactionQueryBuilderDsl Of()
        {
            return new TransactionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TransactionQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<TransactionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<TransactionQueryBuilderDsl>(p, TransactionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TransactionQueryBuilderDsl, DateTime> Timestamp()
        {
            return new ComparisonPredicateBuilder<TransactionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("timestamp")),
            p => new CombinationQueryPredicate<TransactionQueryBuilderDsl>(p, TransactionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TransactionQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<TransactionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<TransactionQueryBuilderDsl>(p, TransactionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TransactionQueryBuilderDsl> Amount(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TransactionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("amount"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                TransactionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<TransactionQueryBuilderDsl, string> InteractionId()
        {
            return new ComparisonPredicateBuilder<TransactionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interactionId")),
            p => new CombinationQueryPredicate<TransactionQueryBuilderDsl>(p, TransactionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TransactionQueryBuilderDsl, string> State()
        {
            return new ComparisonPredicateBuilder<TransactionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
            p => new CombinationQueryPredicate<TransactionQueryBuilderDsl>(p, TransactionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TransactionQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TransactionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                TransactionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<TransactionQueryBuilderDsl, string> InterfaceId()
        {
            return new ComparisonPredicateBuilder<TransactionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceId")),
            p => new CombinationQueryPredicate<TransactionQueryBuilderDsl>(p, TransactionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
