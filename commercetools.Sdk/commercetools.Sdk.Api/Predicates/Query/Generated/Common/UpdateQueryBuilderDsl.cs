using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Common
{

    public partial class UpdateQueryBuilderDsl
    {
        public UpdateQueryBuilderDsl()
        {
        }

        public static UpdateQueryBuilderDsl Of()
        {
            return new UpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<UpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<UpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<UpdateQueryBuilderDsl>(p, UpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<UpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.UpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.UpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<UpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.UpdateActionQueryBuilderDsl.Of())),
                UpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<UpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<UpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<UpdateQueryBuilderDsl>(p, UpdateQueryBuilderDsl.Of));
        }

    }
}
