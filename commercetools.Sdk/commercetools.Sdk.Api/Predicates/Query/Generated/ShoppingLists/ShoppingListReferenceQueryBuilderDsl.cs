using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShoppingLists
{

    public partial class ShoppingListReferenceQueryBuilderDsl
    {
        public ShoppingListReferenceQueryBuilderDsl()
        {
        }

        public static ShoppingListReferenceQueryBuilderDsl Of()
        {
            return new ShoppingListReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShoppingListReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ShoppingListReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ShoppingListReferenceQueryBuilderDsl>(p, ShoppingListReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShoppingListReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ShoppingListReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ShoppingListReferenceQueryBuilderDsl>(p, ShoppingListReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ShoppingListReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ShoppingListReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ShoppingLists.ShoppingListQueryBuilderDsl.Of())),
                ShoppingListReferenceQueryBuilderDsl.Of);
        }


    }
}
