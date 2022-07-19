﻿namespace OSV.Models;

public sealed record Severity
{
    /// <summary>
    /// The type of this severity entry.
    /// </summary>
    [JsonPropertyName("type")]
    public SeverityType Type { get; init; }

    /// <summary>
    /// The quantitative score.
    /// </summary>
    [JsonPropertyName("score")]
    public string Score { get; init; } = null!;
}
