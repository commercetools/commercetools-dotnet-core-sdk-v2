using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectChangeShoppingListsConfigurationActionQueryBuilderDsl
    {
        public ProjectChangeShoppingListsConfigurationActionQueryBuilderDsl()
        {
        }

        public static ProjectChangeShoppingListsConfigurationActionQueryBuilderDsl Of()
        {
            return new ProjectChangeShoppingListsConfigurationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectChangeShoppingListsConfigurationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectChangeShoppingListsConfigurationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectChangeShoppingListsConfigurationActionQueryBuilderDsl>(p, ProjectChangeShoppingListsConfigurationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProjectChangeShoppingListsConfigurationActionQueryBuilderDsl> ShoppingListsConfiguration(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ShoppingListsConfigurationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ShoppingListsConfigurationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectChangeShoppingListsConfigurationActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("shoppingListsConfiguration"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ShoppingListsConfigurationQueryBuilderDsl.Of())),
                ProjectChangeShoppingListsConfigurationActionQueryBuilderDsl.Of);
        }


    }
}
