﻿// Copyright © 2024 Greeana LLC. All rights reserved.
// Use of this source code is governed by MIT license that can be found in the LICENSE file.

namespace Chromatron.Browser;

/// <summary>
/// The load start event args.
/// </summary>
public class FrameLoadStartEventArgs : EventArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FrameLoadStartEventArgs"/> class.
    /// </summary>
    /// <param name="frame">
    /// The frame.
    /// </param>
    public FrameLoadStartEventArgs(CefFrame frame)
    {
        Frame = frame;
    }

    /// <summary>
    /// Gets the frame.
    /// </summary>
    public CefFrame Frame { get; }
}