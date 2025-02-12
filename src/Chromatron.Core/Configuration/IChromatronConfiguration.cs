﻿// Copyright © 2024 Greeana LLC. All rights reserved.
// Use of this source code is governed by MIT license that can be found in the LICENSE file.

namespace Chromatron.Core.Configuration;

/// <summary>
/// Chromatron main configuation class.
/// </summary>
public interface IChromatronConfiguration
{
    /// <summary>
    /// Gets or sets the name of the application.
    /// </summary>
    string? AppName { get; set; }

    /// <summary>
    /// Gets or sets the start URL.
    /// </summary>
    string StartUrl { get; set; }

    /// <summary>
    /// Gets or sets the application executable location.
    /// </summary>
    string AppExeLocation { get; set; }

    /// <summary>
    /// Gets or sets the Chromatron version.
    /// </summary>
    string? ChromatronVersion { get; set; }

    /// <summary>
    /// Gets or sets the platform.
    /// </summary>
    ChromatronPlatform Platform { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether debugging is enabled or not.
    /// </summary>
    bool DebuggingMode { get; set; }

    /// <summary>
    /// Gets or sets the dev tools URL.
    /// </summary>
    string? DevToolsUrl { get; set; }

    /// <summary>
    /// Gets or sets the command line arguments.
    /// </summary>
    Dictionary<string, string>? CommandLineArgs { get; set; }

    /// <summary>
    /// Gets or sets the command line options.
    /// </summary>
    List<string>? CommandLineOptions { get; set; }

    /// <summary>
    /// Gets or sets the custom settings.
    /// </summary>
    Dictionary<string, string>? CustomSettings { get; set; }

    /// <summary>
    /// Gets or sets the extension data.
    /// </summary>
    Dictionary<string, object>? ExtensionData { get; set; }

    /// <summary>
    /// Gets or sets the JavaScript scripts executor.
    /// </summary>
    IChromatronJavaScriptExecutor? JavaScriptExecutor { get; set; }

    /// <summary>
    /// Gets or sets the URL schemes.
    /// </summary>
    List<UrlScheme> UrlSchemes { get; set; }

    /// <summary>
    /// Gets or sets <see cref="Configuration.CefDownloadOptions"/> for CEF download options.
    /// </summary>
    CefDownloadOptions CefDownloadOptions { get; set; }

    /// <summary>
    /// Gets or sets <see cref="IWindowOptions"/> for window options.
    /// </summary>
    IWindowOptions WindowOptions { get; set; }
}