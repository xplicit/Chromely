﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Chromatron.NativeHosts.WinHost;

public static partial class Interop
{
    public static partial class User32
    {
        public enum MONITOR : uint
        {
            DEFAULTTONULL = 0x00000000,
            DEFAULTTOPRIMARY = 0x00000001,
            DEFAULTTONEAREST = 0x00000002
        }
    }
}