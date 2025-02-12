﻿// Copyright © 2024 Greeana LLC. All rights reserved.
// Use of this source code is governed by MIT license that can be found in the LICENSE file.

namespace Chromatron.Core.Logging;

internal class LogEntry
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LogEntry" /> class.
    /// </summary>
    public LogEntry(LogLevel level, string entry)
    {
        LogLevel = level;
        Entry = entry;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LogEntry" /> class.
    /// </summary>
    public LogEntry(LogLevel level, Exception? error)
    {
        LogLevel = level;
        Entry = string.Empty;
        Error = error;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LogEntry" /> class.
    /// </summary>
    public LogEntry(LogLevel level, string entry, Exception? error)
    {
        LogLevel = level;
        Entry = entry;
        Error = error;
    }

    /// <summary>
    /// Gets the log level.
    /// </summary>
    public LogLevel LogLevel { get; }

    /// <summary>
    /// Gets the entry.
    /// </summary>
    public string Entry { get; }

    /// <summary>
    /// Gets or sets the error.
    /// </summary>
    public Exception? Error { get; set; }

    /// <summary>
    /// The to string.
    /// </summary>
    public override string ToString()
    {
        const string DefaultMessage = "Oops! Something went wrong.";
        string formattedMessage = Entry;

        if (string.IsNullOrEmpty(formattedMessage))
        {
            formattedMessage = DefaultMessage;
        }

        if (Error is not null)
        {
            formattedMessage = $"{formattedMessage}\t{Error.Message}\t{Error.StackTrace}";
        }

        string levelText = LogLevel switch
        {
            LogLevel.Trace => "[TRACE]",
            LogLevel.Information => "[INFO]",
            LogLevel.Debug => "[DEBUG]",
            LogLevel.Warning => "[WARNING]",
            LogLevel.Error => "[ERROR]",
            _ => "[UNKNOWN LEVEL]",
        };
        string datetimeFormat = "yyyy-MM-dd HH:mm:ss.fff";
        return $"{DateTime.Now.ToString(datetimeFormat)} {levelText} {formattedMessage}";
    }
}