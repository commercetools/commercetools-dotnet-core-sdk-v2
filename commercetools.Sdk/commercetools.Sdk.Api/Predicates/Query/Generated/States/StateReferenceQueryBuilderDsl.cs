using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.States
{

    public partial class StateReferenceQueryBuilderDsl
    {
        public StateReferenceQueryBuilderDsl()
        {
        }

        public static StateReferenceQueryBuilderDsl Of()
        {
            return new StateReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StateReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<StateReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<StateReferenceQueryBuilderDsl>(p, StateReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StateReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StateReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StateReferenceQueryBuilderDsl>(p, StateReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StateReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StateReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateQueryBuilderDsl.Of())),
                StateReferenceQueryBuilderDsl.Of);
        }


    }
}
