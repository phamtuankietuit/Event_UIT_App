﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Reflection;
using UITEventAPI.Application.Common.Utils;
using UITEventAPI.Application.Domain.Events;

namespace UITEventAPI.Application.Extensions;

public static class QueryableExtensions
{
    public static IOrderedQueryable<T> OrderBy<T>(this IQueryable<T> query, string propertyName, bool sortAscending)
    {
        if (string.IsNullOrEmpty(propertyName))
        {
            var defaultProperty = "Id";

            return sortAscending
                ? query.OrderBy($"{defaultProperty}")
                : query.OrderByDescending($"{defaultProperty}");
        }

        _ = typeof(T).GetProperty(propertyName) ?? throw new ArgumentException($"'{propertyName}' is not a valid property of '{typeof(T).FullName}'");
        
        return sortAscending
            ? query.OrderBy($"{propertyName}")
            : query.OrderByDescending($"{propertyName}");
    }

    public static IOrderedQueryable<TSource> OrderBy<TSource>(
       this IQueryable<TSource> query, string propertyName)
    {
        var entityType = typeof(TSource);

        //Create x=>x.PropName
        var propertyInfo = entityType.GetProperty(propertyName);
        ParameterExpression arg = Expression.Parameter(entityType, "x");
        MemberExpression property = Expression.Property(arg, propertyName);
        var selector = Expression.Lambda(property, new ParameterExpression[] { arg });

        //Get System.Linq.Queryable.OrderBy() method.
        var enumarableType = typeof(System.Linq.Queryable);
        var method = enumarableType.GetMethods()
             .Where(m => m.Name == "OrderBy" && m.IsGenericMethodDefinition)
             .Where(m =>
             {
                 var parameters = m.GetParameters().ToList();
                 //Put more restriction here to ensure selecting the right overload                
                 return parameters.Count == 2;//overload that has 2 parameters
             }).Single();
        //The linq's OrderBy<TSource, TKey> has two generic types, which provided here
        MethodInfo genericMethod = method
             .MakeGenericMethod(entityType, propertyInfo.PropertyType);

        /*Call query.OrderBy(selector), with query and selector: x=> x.PropName
          Note that we pass the selector as Expression to the method and we don't compile it.
          By doing so EF can extract "order by" columns and generate SQL for it.*/
        var newQuery = (IOrderedQueryable<TSource>?)genericMethod
             .Invoke(genericMethod, new object[] { query, selector });
        return newQuery;
    }

    public static IOrderedQueryable<TSource> OrderByDescending<TSource>(
       this IQueryable<TSource> query, string propertyName)
    {
        var entityType = typeof(TSource);

        //Create x=>x.PropName
        var propertyInfo = entityType.GetProperty(propertyName);
        ParameterExpression arg = Expression.Parameter(entityType, "x");
        MemberExpression property = Expression.Property(arg, propertyName);
        var selector = Expression.Lambda(property, new ParameterExpression[] { arg });

        //Get System.Linq.Queryable.OrderBy() method.
        var enumarableType = typeof(System.Linq.Queryable);
        var method = enumarableType.GetMethods()
             .Where(m => m.Name == "OrderByDescending" && m.IsGenericMethodDefinition)
             .Where(m =>
             {
                 var parameters = m.GetParameters().ToList();
                 //Put more restriction here to ensure selecting the right overload                
                 return parameters.Count == 2;//overload that has 2 parameters
             }).Single();
        //The linq's OrderBy<TSource, TKey> has two generic types, which provided here
        MethodInfo genericMethod = method
             .MakeGenericMethod(entityType, propertyInfo.PropertyType);

        /*Call query.OrderBy(selector), with query and selector: x=> x.PropName
          Note that we pass the selector as Expression to the method and we don't compile it.
          By doing so EF can extract "order by" columns and generate SQL for it.*/
        var newQuery = (IOrderedQueryable<TSource>?)genericMethod
             .Invoke(genericMethod, new object[] { query, selector });

        return newQuery;
    }
}
