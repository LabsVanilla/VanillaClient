// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license. 
// See license.txt file in the project root for full license information.
using Vanilla.Tomlyn.Collections;

namespace Vanilla.Tomlyn.Text
{
    /// <summary>
    /// (trait) CharacterIterator ala Stark
    /// </summary>
    // ReSharper disable once InconsistentNaming
    internal interface CharacterIterator : Iterator<char32, int>
    {
    }
}