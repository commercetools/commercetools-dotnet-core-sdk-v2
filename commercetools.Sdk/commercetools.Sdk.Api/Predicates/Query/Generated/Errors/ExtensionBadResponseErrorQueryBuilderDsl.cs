using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ExtensionBadResponseErrorQueryBuilderDsl
    {
        public ExtensionBadResponseErrorQueryBuilderDsl()
        {
        }

        public static ExtensionBadResponseErrorQueryBuilderDsl Of()
        {
            return new ExtensionBadResponseErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ExtensionBadResponseErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ExtensionBadResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ExtensionBadResponseErrorQueryBuilderDsl>(p, ExtensionBadResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionBadResponseErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ExtensionBadResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ExtensionBadResponseErrorQueryBuilderDsl>(p, ExtensionBadResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionBadResponseErrorQueryBuilderDsl> LocalizedMessage(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionBadResponseErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("localizedMessage"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ExtensionBadResponseErrorQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ExtensionBadResponseErrorQueryBuilderDsl, string> ExtensionExtraInfo()
        {
            return new ComparisonPredicateBuilder<ExtensionBadResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionExtraInfo")),
            p => new CombinationQueryPredicate<ExtensionBadResponseErrorQueryBuilderDsl>(p, ExtensionBadResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ExtensionBadResponseErrorQueryBuilderDsl> ExtensionErrors(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ExtensionBadResponseErrorQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("extensionErrors"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionErrorQueryBuilderDsl.Of())),
                ExtensionBadResponseErrorQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ExtensionBadResponseErrorQueryBuilderDsl> ExtensionErrors()
        {
            return new CollectionPredicateBuilder<ExtensionBadResponseErrorQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionErrors")),
                    p => new CombinationQueryPredicate<ExtensionBadResponseErrorQueryBuilderDsl>(p, ExtensionBadResponseErrorQueryBuilderDsl.Of));
        }
        public IComparisonPredicateBuilder<ExtensionBadResponseErrorQueryBuilderDsl, string> ExtensionBody()
        {
            return new ComparisonPredicateBuilder<ExtensionBadResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionBody")),
            p => new CombinationQueryPredicate<ExtensionBadResponseErrorQueryBuilderDsl>(p, ExtensionBadResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionBadResponseErrorQueryBuilderDsl, long> ExtensionStatusCode()
        {
            return new ComparisonPredicateBuilder<ExtensionBadResponseErrorQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionStatusCode")),
            p => new CombinationQueryPredicate<ExtensionBadResponseErrorQueryBuilderDsl>(p, ExtensionBadResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionBadResponseErrorQueryBuilderDsl, string> ExtensionId()
        {
            return new ComparisonPredicateBuilder<ExtensionBadResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionId")),
            p => new CombinationQueryPredicate<ExtensionBadResponseErrorQueryBuilderDsl>(p, ExtensionBadResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ExtensionBadResponseErrorQueryBuilderDsl, string> ExtensionKey()
        {
            return new ComparisonPredicateBuilder<ExtensionBadResponseErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("extensionKey")),
            p => new CombinationQueryPredicate<ExtensionBadResponseErrorQueryBuilderDsl>(p, ExtensionBadResponseErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
