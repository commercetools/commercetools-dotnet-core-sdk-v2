using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Projects
{

    public partial class ProjectSetExternalOAuthActionQueryBuilderDsl
    {
        public ProjectSetExternalOAuthActionQueryBuilderDsl()
        {
        }

        public static ProjectSetExternalOAuthActionQueryBuilderDsl Of()
        {
            return new ProjectSetExternalOAuthActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectSetExternalOAuthActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProjectSetExternalOAuthActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProjectSetExternalOAuthActionQueryBuilderDsl>(p, ProjectSetExternalOAuthActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProjectSetExternalOAuthActionQueryBuilderDsl> ExternalOAuth(
            Func<commercetools.Sdk.Api.Predicates.Query.Projects.ExternalOAuthQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Projects.ExternalOAuthQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProjectSetExternalOAuthActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("externalOAuth"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Projects.ExternalOAuthQueryBuilderDsl.Of())),
                ProjectSetExternalOAuthActionQueryBuilderDsl.Of);
        }


    }
}
