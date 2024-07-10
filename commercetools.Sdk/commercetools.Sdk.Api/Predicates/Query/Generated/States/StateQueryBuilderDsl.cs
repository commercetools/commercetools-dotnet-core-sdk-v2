using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.States
{

    public partial class StateQueryBuilderDsl
    {
        public StateQueryBuilderDsl()
        {
        }

        public static StateQueryBuilderDsl Of()
        {
            return new StateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StateQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StateQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StateQueryBuilderDsl>(p, StateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<StateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<StateQueryBuilderDsl>(p, StateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StateQueryBuilderDsl, DateTime> CreatedAt()
        {
            return new ComparisonPredicateBuilder<StateQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("createdAt")),
            p => new CombinationQueryPredicate<StateQueryBuilderDsl>(p, StateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StateQueryBuilderDsl, DateTime> LastModifiedAt()
        {
            return new ComparisonPredicateBuilder<StateQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastModifiedAt")),
            p => new CombinationQueryPredicate<StateQueryBuilderDsl>(p, StateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StateQueryBuilderDsl> LastModifiedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("lastModifiedBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LastModifiedByQueryBuilderDsl.Of())),
                StateQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StateQueryBuilderDsl> CreatedBy(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("createdBy"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CreatedByQueryBuilderDsl.Of())),
                StateQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StateQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<StateQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<StateQueryBuilderDsl>(p, StateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StateQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StateQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StateQueryBuilderDsl>(p, StateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StateQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                StateQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StateQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                StateQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StateQueryBuilderDsl, bool> Initial()
        {
            return new ComparisonPredicateBuilder<StateQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("initial")),
            p => new CombinationQueryPredicate<StateQueryBuilderDsl>(p, StateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StateQueryBuilderDsl, bool> BuiltIn()
        {
            return new ComparisonPredicateBuilder<StateQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("builtIn")),
            p => new CombinationQueryPredicate<StateQueryBuilderDsl>(p, StateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<StateQueryBuilderDsl, string> Roles()
        {
            return new ComparableCollectionPredicateBuilder<StateQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("roles")),
            p => new CombinationQueryPredicate<StateQueryBuilderDsl>(p, StateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StateQueryBuilderDsl> Transitions(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("transitions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                StateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StateQueryBuilderDsl> Transitions()
        {
            return new CollectionPredicateBuilder<StateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transitions")),
                    p => new CombinationQueryPredicate<StateQueryBuilderDsl>(p, StateQueryBuilderDsl.Of));
        }

    }
}
