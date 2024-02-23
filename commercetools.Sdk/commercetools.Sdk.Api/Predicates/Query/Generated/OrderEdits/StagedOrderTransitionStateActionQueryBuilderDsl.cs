using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderTransitionStateActionQueryBuilderDsl
    {
        public StagedOrderTransitionStateActionQueryBuilderDsl()
        {
        }

        public static StagedOrderTransitionStateActionQueryBuilderDsl Of()
        {
            return new StagedOrderTransitionStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderTransitionStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderTransitionStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderTransitionStateActionQueryBuilderDsl>(p, StagedOrderTransitionStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderTransitionStateActionQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderTransitionStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                StagedOrderTransitionStateActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedOrderTransitionStateActionQueryBuilderDsl, bool> Force()
        {
            return new ComparisonPredicateBuilder<StagedOrderTransitionStateActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("force")),
            p => new CombinationQueryPredicate<StagedOrderTransitionStateActionQueryBuilderDsl>(p, StagedOrderTransitionStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
