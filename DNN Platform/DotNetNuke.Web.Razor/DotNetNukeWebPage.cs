﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Web.Razor
{
    using System;
    using System.Web.WebPages;

    using DotNetNuke.Web.Razor.Helpers;

    [Obsolete("Deprecated in 9.3.2, will be removed in 11.0.0, use Razor Pages instead")]
    public abstract class DotNetNukeWebPage : WebPageBase
    {
        private dynamic model;

        [Obsolete("Deprecated in 9.3.2, will be removed in 11.0.0, use Razor Pages instead")]
        public dynamic Model
        {
            get { return this.model ?? (this.model = this.PageContext.Model); }
            set { this.model = value; }
        }

        [Obsolete("Deprecated in 9.3.2, will be removed in 11.0.0, use Razor Pages instead")]
        protected internal DnnHelper Dnn { get; internal set; }

        [Obsolete("Deprecated in 9.3.2, will be removed in 11.0.0, use Razor Pages instead")]
        protected internal HtmlHelper Html { get; internal set; }

        [Obsolete("Deprecated in 9.3.2, will be removed in 11.0.0, use Razor Pages instead")]
        protected internal UrlHelper Url { get; internal set; }

        /// <inheritdoc/>
        [Obsolete("Deprecated in 9.3.2, will be removed in 11.0.0, use Razor Pages instead")]
        protected override void ConfigurePage(WebPageBase parentPage)
        {
            base.ConfigurePage(parentPage);

            // Child pages need to get their context from the Parent
            this.Context = parentPage.Context;
        }
    }
}
