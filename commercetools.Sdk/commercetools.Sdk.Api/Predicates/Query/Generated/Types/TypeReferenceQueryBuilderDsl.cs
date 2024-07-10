using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeReferenceQueryBuilderDsl
    {
        public TypeReferenceQueryBuilderDsl()
        {
        }

        public static TypeReferenceQueryBuilderDsl Of()
        {
            return new TypeReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<TypeReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<TypeReferenceQueryBuilderDsl>(p, TypeReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<TypeReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<TypeReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<TypeReferenceQueryBuilderDsl>(p, TypeReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TypeReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.TypeQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.TypeQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.TypeQueryBuilderDsl.Of())),
                TypeReferenceQueryBuilderDsl.Of);
        }


    }
}
