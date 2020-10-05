// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Mvc.Rendering;

namespace Microsoft.AspNetCore.Mvc.ViewFeatures
{
    /// <summary>
    /// Static class that adds extension methods to <see cref="IHtmlGenerator"/>.
    /// </summary>
    public static class DefaultHtmlGeneratorExtensions
    {
        /// <summary>
        /// Generates a form.
        /// </summary>
        /// <param name="generator">The <see cref="IHtmlGenerator"/>.</param>
        /// <param name="viewContext">The <see cref="ViewContext"/>.</param>
        /// <param name="actionName">The action name.</param>
        /// <param name="controllerName">The name of the controller.</param>
        /// <param name="fragment">The fragment.</param>
        /// <param name="routeValues">The route values.</param>
        /// <param name="method">The form method.</param>
        /// <param name="htmlAttributes">The html attributes.</param>
        /// <returns></returns>
        public static TagBuilder GenerateForm(
            this IHtmlGenerator generator,
            ViewContext viewContext,
            string actionName,
            string controllerName,
            string fragment,
            object routeValues,
            string method,
            object htmlAttributes)
        {
            var tagBuilder = generator.GenerateForm(viewContext, actionName, controllerName, routeValues, method, htmlAttributes);

            // Append the fragment to action
            if (fragment != null)
            {
                tagBuilder.Attributes["action"] += "#" + fragment;
            }

            return tagBuilder;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="generator">The <see cref="IHtmlGenerator"/>.</param>
        /// <param name="viewContext">The <see cref="ViewContext"/>.</param>
        /// <param name="routeName">The nam eof the route.</param>
        /// <param name="routeValues">The route values.</param>
        /// <param name="fragment">The fragment.</param>
        /// <param name="method">The form method.</param>
        /// <param name="htmlAttributes">The html attributes.</param>
        /// <returns>The <see cref="TagBuilder"/>.</returns>
        public static TagBuilder GenerateRouteForm(
            this IHtmlGenerator generator,
            ViewContext viewContext,
            string routeName,
            object routeValues,
            string fragment,
            string method,
            object htmlAttributes)
        {
            var tagBuilder = generator.GenerateRouteForm(viewContext, routeName, routeValues, method, htmlAttributes);

            // Append the fragment to action
            if (fragment != null)
            {
                tagBuilder.Attributes["action"] += "#" + fragment;
            }

            return tagBuilder;
        }
    }
}
