using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectUpdateQueryBuilderDsl
    {
        public ProjectUpdateQueryBuilderDsl()
        {
        }

        public static ProjectUpdateQueryBuilderDsl Of()
        {
            return new ProjectUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProjectUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProjectUpdateQueryBuilderDsl>(p, ProjectUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProjectUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ProjectUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ProjectUpdateActionQueryBuilderDsl.Of())),
                ProjectUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProjectUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<ProjectUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<ProjectUpdateQueryBuilderDsl>(p, ProjectUpdateQueryBuilderDsl.Of));
        }

    }
}
