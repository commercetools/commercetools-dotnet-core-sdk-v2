using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentTransactionAddedMessageQueryBuilderDsl
    {
        public PaymentTransactionAddedMessageQueryBuilderDsl()
        {
        }

        public static PaymentTransactionAddedMessageQueryBuilderDsl Of()
        {
            return new PaymentTransactionAddedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentTransactionAddedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl>(p, PaymentTransactionAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentTransactionAddedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl>(p, PaymentTransactionAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentTransactionAddedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl>(p, PaymentTransactionAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentTransactionAddedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionAddedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl>(p, PaymentTransactionAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                PaymentTransactionAddedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                PaymentTransactionAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentTransactionAddedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl>(p, PaymentTransactionAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                PaymentTransactionAddedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentTransactionAddedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionAddedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl>(p, PaymentTransactionAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentTransactionAddedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentTransactionAddedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl>(p, PaymentTransactionAddedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                PaymentTransactionAddedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl> Transaction(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.TransactionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.TransactionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentTransactionAddedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("transaction"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.TransactionQueryBuilderDsl.Of())),
                PaymentTransactionAddedMessageQueryBuilderDsl.Of);
        }


    }
}
