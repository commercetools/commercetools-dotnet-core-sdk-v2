using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Extensions
{

    public partial class ExtensionReferenceQueryBuilderDsl
    {
        public ExtensionReferenceQueryBuilderDsl()
        {
        }

        public static ExtensionReferenceQueryBuilderDsl Of()
        {
            return new ExtensionReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ExtensionReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ExtensionReferenceQueryBuilderDsl>(p, ExtensionReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ExtensionReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ExtensionReferenceQueryBuilderDsl>(p, ExtensionReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Extensions.ExtensionQueryBuilderDsl.Of())),
                ExtensionReferenceQueryBuilderDsl.Of);
        }


    }
}
