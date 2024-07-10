using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionInputQueryBuilderDsl
    {
        public ExtensionInputQueryBuilderDsl()
        {
        }

        public static ExtensionInputQueryBuilderDsl Of()
        {
            return new ExtensionInputQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionInputQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ExtensionInputQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ExtensionInputQueryBuilderDsl>(p, ExtensionInputQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionInputQueryBuilderDsl> Resource(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionInputQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("resource"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ExtensionInputQueryBuilderDsl.Of);
        }


    }
}
