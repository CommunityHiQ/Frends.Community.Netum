namespace Frends.Community.PDF.Definitions;

/// <summary>
/// Result class usually contains properties of the return object.
/// </summary>
public class Result
{
    internal Result(byte[] output)
    {
        this.OutputFileBytes = output;
    }

    /// <summary>
    /// Contains the input repeated the specified number of times.
    /// </summary>
    /// <example>Example of the output</example>
    public byte[] OutputFileBytes { get; private set; }
}
