using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ShoppingListMessageQueryBuilderDsl
    {
        public ShoppingListMessageQueryBuilderDsl()
        {
        }

        public static ShoppingListMessageQueryBuilderDsl Of()
        {
            return new ShoppingListMessageQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListMessageQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ShoppingListMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl>(p, ShoppingListMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListMessageQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ShoppingListMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl>(p, ShoppingListMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListMessageQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<ShoppingListMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl>(p, ShoppingListMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListMessageQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<ShoppingListMessageQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl>(p, ShoppingListMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                ShoppingListMessageQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                ShoppingListMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShoppingListMessageQueryBuilderDsl, long> SequenceNumber()
        {
            return new ComparisonPredicateBuilder<ShoppingListMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("sequenceNumber")),
            p => new CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl>(p, ShoppingListMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ShoppingListMessageQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ShoppingListMessageQueryBuilderDsl, long> ResourceVersion()
        {
            return new ComparisonPredicateBuilder<ShoppingListMessageQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceVersion")),
            p => new CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl>(p, ShoppingListMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListMessageQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ShoppingListMessageQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl>(p, ShoppingListMessageQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl> ResourceUserProvidedIdentifiers(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resourceUserProvidedIdentifiers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.UserProvidedIdentifiersQueryBuilderDsl.Of())),
                ShoppingListMessageQueryBuilderDsl.Of);
        }


        public CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl> AsShoppingListLineItemAdded(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListLineItemAddedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListLineItemAddedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListLineItemAddedMessageQueryBuilderDsl.Of()),
                ShoppingListMessageQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl> AsShoppingListLineItemRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListLineItemRemovedMessageQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListLineItemRemovedMessageQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListMessageQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Messages.ShoppingListLineItemRemovedMessageQueryBuilderDsl.Of()),
                ShoppingListMessageQueryBuilderDsl.Of);
        }
    }
}
