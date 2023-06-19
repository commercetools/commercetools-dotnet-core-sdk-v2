using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CustomObjects
{

    public partial class CustomObjectReferenceQueryBuilderDsl
    {
        public CustomObjectReferenceQueryBuilderDsl()
        {
        }

        public static CustomObjectReferenceQueryBuilderDsl Of()
        {
            return new CustomObjectReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CustomObjectReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<CustomObjectReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<CustomObjectReferenceQueryBuilderDsl>(p, CustomObjectReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CustomObjectReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<CustomObjectReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<CustomObjectReferenceQueryBuilderDsl>(p, CustomObjectReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CustomObjectReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.CustomObjects.CustomObjectQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.CustomObjects.CustomObjectQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CustomObjectReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.CustomObjects.CustomObjectQueryBuilderDsl.Of())),
                CustomObjectReferenceQueryBuilderDsl.Of);
        }


    }
}
