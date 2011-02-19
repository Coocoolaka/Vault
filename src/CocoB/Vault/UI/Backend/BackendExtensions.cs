﻿/*
 * BackendExtensions.cs
 *
 * Code from the Build Your Own MVVM talk by Rob Eisenberg at MIX10 conference.
 * Ref: http://devlicio.us/blogs/rob_eisenberg/archive/2010/03/16/build-your-own-mvvm-framework-is-online.aspx
 * 
 * Adopted to Sphinx platform by
 * Author: Kelum Peiris (kelum.peiris@polarmobile.com)
 * Date: 12/11/2010 6:57:10 PM
 *
 */

using CocoB.Vault.UI.Framework;

namespace CocoB.Vault.UI.Backend
{
    public static class BackendExtensions
    {
        #region Methods

        public static QueryResult<TResponse> AsResult<TResponse>(this IQuery<TResponse> query)
        {
            return new QueryResult<TResponse>(query);
        }

        public static CommandResult AsResult(this ICommand command)
        {
            return new CommandResult(command);
        }

        #endregion
    }
}