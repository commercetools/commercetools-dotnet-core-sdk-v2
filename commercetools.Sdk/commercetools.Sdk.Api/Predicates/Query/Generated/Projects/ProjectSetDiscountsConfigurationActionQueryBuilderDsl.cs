using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectSetDiscountsConfigurationActionQueryBuilderDsl
    {
        public ProjectSetDiscountsConfigurationActionQueryBuilderDsl()
        {
        }

        public static ProjectSetDiscountsConfigurationActionQueryBuilderDsl Of()
        {
            return new ProjectSetDiscountsConfigurationActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectSetDiscountsConfigurationActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectSetDiscountsConfigurationActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectSetDiscountsConfigurationActionQueryBuilderDsl>(p, ProjectSetDiscountsConfigurationActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProjectSetDiscountsConfigurationActionQueryBuilderDsl> DiscountsConfiguration(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.DiscountsConfigurationQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.DiscountsConfigurationQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectSetDiscountsConfigurationActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("discountsConfiguration"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.DiscountsConfigurationQueryBuilderDsl.Of())),
                ProjectSetDiscountsConfigurationActionQueryBuilderDsl.Of);
        }


    }
}
