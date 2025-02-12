﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Chromatron.NativeHosts.WinHost;

public static partial class Interop
{
    public static partial class User32
    {
        public enum WINDOW_SIZE
        {
            RESTORED = 0,
            MINIMIZED = 1,
            MAXIMIZED = 2,
            MAXSHOW = 3,
            MAXHIDE = 4
        }
    }
}
