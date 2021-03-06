// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.AspNet.Routing
{
    /// <summary>
    /// Defines a contract for a route builder in an application. A route builder specifies the routes for an application.
    /// </summary>
    public interface IRouteBuilder
    {
        /// <summary>
        /// Gets or sets the default <see cref="IRouter"/> that is used if an <see cref="IRouter"/> is added to the list of routes but does not specify its own.
        /// </summary>
        IRouter DefaultHandler { get; set; }

        IServiceProvider ServiceProvider { get; }

        /// <summary>
        /// Gets the routes configured in the builder.
        /// </summary>
        IList<IRouter> Routes { get; }

        /// <summary>
        /// Builds an <see cref="IRouter"/> that routes the routes specified in the <see cref="Routes"/> property.
        /// </summary>
        IRouter Build();
    }
}