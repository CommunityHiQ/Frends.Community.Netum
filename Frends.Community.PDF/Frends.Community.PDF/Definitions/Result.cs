namespace Frends.Community.PdfMerge.Definitions;

/// <summary>
/// Result of PDF merge operation containing the merged PDF file.
/// </summary>
public class Result
{
    internal Result(byte[] output)
    {
        this.OutputFileBytes = output;
    }

    /// <summary>
    /// The merged PDF file as a byte array.
    /// </summary>
    /// <example>File.WriteAllBytes(@"C:\path\to\merged.pdf", result.OutputFileBytes)</example>
    public byte[] OutputFileBytes { get; private set; }
}
