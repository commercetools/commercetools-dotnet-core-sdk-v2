using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ShoppingListLineItemRemovedMessageQueryBuilderDsl
    {
        public ShoppingListLineItemRemovedMessageQueryBuilderDsl()
        {
        }

        public static ShoppingListLineItemRemovedMessageQueryBuilderDsl Of()
        {
            return new ShoppingListLineItemRemovedMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListLineItemRemovedMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl>(p, ShoppingListLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListLineItemRemovedMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl>(p, ShoppingListLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListLineItemRemovedMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl>(p, ShoppingListLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListLineItemRemovedMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemRemovedMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl>(p, ShoppingListLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ShoppingListLineItemRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ShoppingListLineItemRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShoppingListLineItemRemovedMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl>(p, ShoppingListLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ShoppingListLineItemRemovedMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShoppingListLineItemRemovedMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemRemovedMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl>(p, ShoppingListLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListLineItemRemovedMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ShoppingListLineItemRemovedMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl>(p, ShoppingListLineItemRemovedMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ShoppingListLineItemRemovedMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl> LineItem(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListLineItemRemovedMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lineItem"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListLineItemQueryBuilderDsl.Of())),
                ShoppingListLineItemRemovedMessageQueryBuilderDsl.Of);
        }


    }
}
