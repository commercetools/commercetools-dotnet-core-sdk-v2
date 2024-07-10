using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Types
{

    public partial class TypeChangeNameActionQueryBuilderDsl
    {
        public TypeChangeNameActionQueryBuilderDsl()
        {
        }

        public static TypeChangeNameActionQueryBuilderDsl Of()
        {
            return new TypeChangeNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<TypeChangeNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<TypeChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<TypeChangeNameActionQueryBuilderDsl>(p, TypeChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<TypeChangeNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<TypeChangeNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                TypeChangeNameActionQueryBuilderDsl.Of);
        }


    }
}
