// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license. 
// See license.txt file in the project root for full license information.
namespace Vanilla.Tomlyn.Model
{
    /// <summary>
    /// Runtime representation of a TOML string
    /// </summary>
    public sealed class TomlString : TomlValue<string>
    {
        public TomlString(string value) : base(ObjectKind.String, value)
        {
        }
    }
}