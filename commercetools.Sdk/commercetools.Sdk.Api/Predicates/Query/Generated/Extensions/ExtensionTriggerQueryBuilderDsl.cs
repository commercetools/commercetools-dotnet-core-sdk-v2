using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionTriggerQueryBuilderDsl
    {
        public ExtensionTriggerQueryBuilderDsl()
        {
        }

        public static ExtensionTriggerQueryBuilderDsl Of()
        {
            return new ExtensionTriggerQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionTriggerQueryBuilderDsl, string> ResourceTypeId()
        {
            return new ComparisonPredicateBuilder<ExtensionTriggerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resourceTypeId")),
            p => new CombinationQueryPredicate<ExtensionTriggerQueryBuilderDsl>(p, ExtensionTriggerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ExtensionTriggerQueryBuilderDsl, string> Actions()
        {
            return new ComparableCollectionPredicateBuilder<ExtensionTriggerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
            p => new CombinationQueryPredicate<ExtensionTriggerQueryBuilderDsl>(p, ExtensionTriggerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionTriggerQueryBuilderDsl, string> Condition()
        {
            return new ComparisonPredicateBuilder<ExtensionTriggerQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("condition")),
            p => new CombinationQueryPredicate<ExtensionTriggerQueryBuilderDsl>(p, ExtensionTriggerQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
