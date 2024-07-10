using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectChangeCartsConfigurationActionQueryBuilderDsl
    {
        public ProjectChangeCartsConfigurationActionQueryBuilderDsl()
        {
        }

        public static ProjectChangeCartsConfigurationActionQueryBuilderDsl Of()
        {
            return new ProjectChangeCartsConfigurationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectChangeCartsConfigurationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectChangeCartsConfigurationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectChangeCartsConfigurationActionQueryBuilderDsl>(p, ProjectChangeCartsConfigurationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProjectChangeCartsConfigurationActionQueryBuilderDsl> CartsConfiguration(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.CartsConfigurationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.CartsConfigurationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectChangeCartsConfigurationActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("cartsConfiguration"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.CartsConfigurationQueryBuilderDsl.Of())),
                ProjectChangeCartsConfigurationActionQueryBuilderDsl.Of);
        }


    }
}
