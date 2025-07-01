using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl
    {
        public PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl()
        {
        }

        public static PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl Of()
        {
            return new PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl>(p, PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl>(p, PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl>(p, PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl>(p, PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl>(p, PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl>(p, PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl>(p, PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, string> InterfaceAccount()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("interfaceAccount")),
            p => new CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl>(p, PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, string> OldInterfaceAccount()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldInterfaceAccount")),
            p => new CombinationQueryPredicate<PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl>(p, PaymentMethodInfoInterfaceAccountSetMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
