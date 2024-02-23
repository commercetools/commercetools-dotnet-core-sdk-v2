using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl
    {
        public AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl()
        {
        }

        public static AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl Of()
        {
            return new AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl>(p, AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl>(p, AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl>(p, AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl>(p, AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl>(p, AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl>(p, AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl>(p, AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, bool> BuyerAssignable()
        {
            return new ComparisonPredicateBuilder<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("buyerAssignable")),
            p => new CombinationQueryPredicate<AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl>(p, AssociateRoleBuyerAssignableChangedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
