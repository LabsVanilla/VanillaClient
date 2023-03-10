// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license. 
// See license.txt file in the project root for full license information.
namespace Vanilla.Tomlyn.Syntax
{
    /// <summary>
    /// Kind of a <see cref="DiagnosticMessage"/>
    /// </summary>
    public enum DiagnosticMessageKind
    {
        /// <summary>
        /// An error message.
        /// </summary>
        Error,

        /// <summary>
        /// A warning message.
        /// </summary>
        Warning,
    }
}