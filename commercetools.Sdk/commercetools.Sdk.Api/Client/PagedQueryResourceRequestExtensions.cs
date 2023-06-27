using System;
using System.Collections.Generic;
using commercetools.Sdk.Api.Predicates.Query;

namespace commercetools.Sdk.Api.Client
{
    public static class PagedQueryResourceRequestExtensions
    {
        public static T WithQuery<T, TResult, TQuery>(this IPagedQueryResourceRequest<T, TResult, TQuery> target, Func<TQuery, IQueryPredicate> fn)
            where T : IPagedQueryResourceRequest<T, TResult, TQuery>
            where TQuery : new()
        {
            return target.WithWhere(fn.Invoke(target.QueryDsl()).Render());
        }

        static T WithPredicateVar<T, TResult, TQuery>(this IPagedQueryResourceRequest<T, TResult, TQuery> target, string varName,
            IEnumerable<string> predicateVar)
            where T : IPagedQueryResourceRequest<T, TResult, TQuery>
            where TQuery : new()
        {
            foreach (var value in predicateVar)
            {
                target.WithPredicateVar(varName, value);
            }
            return (T)target;
        }

        static T WithQuery<T, TResult, TQuery>(this IPagedQueryResourceRequest<T, TResult, TQuery> target, Func<TQuery, IQueryPredicate> fn, string predicateVar,
            string predicateVarValue)
            where T : IPagedQueryResourceRequest<T, TResult, TQuery>
            where TQuery : new()
        {
            return target.WithWhere(fn.Invoke(target.QueryDsl()).Render()).WithPredicateVar(predicateVar, predicateVarValue);
        }

        static T WithQuery<T, TResult, TQuery>(this IPagedQueryResourceRequest<T, TResult, TQuery> target, Func<TQuery, IQueryPredicate> fn, Dictionary<string, IEnumerable<string>> predicateVar)
            where T : IPagedQueryResourceRequest<T, TResult, TQuery>
            where TQuery : new()
        {
            var request = target.WithWhere(fn.Invoke(target.QueryDsl()).Render());
            foreach (var variable in predicateVar)
            {
                request.WithPredicateVar(variable.Key, variable.Value);
            }

            return (T)request;
        }


        static T WithQuery<T, TResult, TQuery>(this IPagedQueryResourceRequest<T, TResult, TQuery> target, Func<TQuery, IQueryPredicate> fn, IEnumerable<KeyValuePair<string, string>> predicateVar)
            where T : IPagedQueryResourceRequest<T, TResult, TQuery>
            where TQuery : new()
        {
            var request = target.WithWhere(fn.Invoke(target.QueryDsl()).Render());
            foreach (var variable in predicateVar)
            {
                request.WithPredicateVar(variable.Key, variable.Value);
            }

            return request;
        }


        static T WithWhere<T, TResult, TQuery>(this IPagedQueryResourceRequest<T, TResult, TQuery> target, string where, string predicateVar, string predicateVarValue)
            where T : IPagedQueryResourceRequest<T, TResult, TQuery>
            where TQuery : new()
        {
            return target.WithWhere(where).WithPredicateVar(predicateVar, predicateVarValue);
        }

        static T WithWhere<T, TResult, TQuery>(this IPagedQueryResourceRequest<T, TResult, TQuery> target, string where, Dictionary<string, IEnumerable<string>> predicateVar)
            where T : IPagedQueryResourceRequest<T, TResult, TQuery>
            where TQuery : new()
        {
            var request = target.WithWhere(where);
            foreach (var variable in predicateVar)
            {
                request.WithPredicateVar(variable.Key, variable.Value);
            }

            return request;
        }

        static T WithWhere<T, TResult, TQuery>(this IPagedQueryResourceRequest<T, TResult, TQuery> target, string where, IEnumerable<KeyValuePair<string, string>> predicateVar)
            where T : IPagedQueryResourceRequest<T, TResult, TQuery>
            where TQuery : new()
        {
            var request = target.WithWhere(where);
            foreach (var variable in predicateVar)
            {
                request.WithPredicateVar(variable.Key, variable.Value);
            }

            return request;
        }
    }
}