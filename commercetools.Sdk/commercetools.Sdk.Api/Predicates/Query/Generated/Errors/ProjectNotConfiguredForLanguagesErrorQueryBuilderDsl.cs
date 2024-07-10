using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl
    {
        public ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl()
        {
        }

        public static ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl Of()
        {
            return new ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl>(p, ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl>(p, ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl, string> Languages()
        {
            return new ComparableCollectionPredicateBuilder<ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("languages")),
            p => new CombinationQueryPredicate<ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl>(p, ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
