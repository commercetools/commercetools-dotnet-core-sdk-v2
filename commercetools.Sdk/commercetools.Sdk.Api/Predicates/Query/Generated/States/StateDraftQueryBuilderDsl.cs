using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.States
{

    public partial class StateDraftQueryBuilderDsl
    {
        public StateDraftQueryBuilderDsl()
        {
        }

        public static StateDraftQueryBuilderDsl Of()
        {
            return new StateDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StateDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<StateDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<StateDraftQueryBuilderDsl>(p, StateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StateDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<StateDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<StateDraftQueryBuilderDsl>(p, StateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StateDraftQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                StateDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<StateDraftQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                StateDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StateDraftQueryBuilderDsl, bool> Initial()
        {
            return new ComparisonPredicateBuilder<StateDraftQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("initial")),
            p => new CombinationQueryPredicate<StateDraftQueryBuilderDsl>(p, StateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<StateDraftQueryBuilderDsl, string> Roles()
        {
            return new ComparableCollectionPredicateBuilder<StateDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("roles")),
            p => new CombinationQueryPredicate<StateDraftQueryBuilderDsl>(p, StateDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StateDraftQueryBuilderDsl> Transitions(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("transitions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                StateDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StateDraftQueryBuilderDsl> Transitions()
        {
            return new CollectionPredicateBuilder<StateDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("transitions")),
                    p => new CombinationQueryPredicate<StateDraftQueryBuilderDsl>(p, StateDraftQueryBuilderDsl.Of));
        }

    }
}
