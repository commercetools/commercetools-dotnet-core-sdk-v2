using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionChangeTriggersActionQueryBuilderDsl
    {
        public ExtensionChangeTriggersActionQueryBuilderDsl()
        {
        }

        public static ExtensionChangeTriggersActionQueryBuilderDsl Of()
        {
            return new ExtensionChangeTriggersActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionChangeTriggersActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ExtensionChangeTriggersActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ExtensionChangeTriggersActionQueryBuilderDsl>(p, ExtensionChangeTriggersActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionChangeTriggersActionQueryBuilderDsl> Triggers(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionTriggerQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionTriggerQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionChangeTriggersActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("triggers"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionTriggerQueryBuilderDsl.Of())),
                ExtensionChangeTriggersActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ExtensionChangeTriggersActionQueryBuilderDsl> Triggers()
        {
            return new CollectionPredicateBuilder<ExtensionChangeTriggersActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("triggers")),
                    p => new CombinationQueryPredicate<ExtensionChangeTriggersActionQueryBuilderDsl>(p, ExtensionChangeTriggersActionQueryBuilderDsl.Of));
        }

    }
}
