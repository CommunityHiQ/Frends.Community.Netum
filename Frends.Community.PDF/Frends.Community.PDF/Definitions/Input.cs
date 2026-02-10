namespace Frends.Community.PdfMerge.Definitions;

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Input class usually contains parameters that are required.
/// </summary>
public class Input
{
    /// <summary>
    /// List of PDF files to merge
    /// </summary>
    /// <example>new List&lt;byte[]&gt; { File.ReadAllBytes(@"C:\path\to\document1.pdf"), File.ReadAllBytes(@"C:\path\to\document2.pdf") }</example>
    [DisplayName("PDF file")]
    [DisplayFormat(DataFormatString = "Expression")]
    [DefaultValue("")]
    public List<byte[]> PageBytes { get; set; }
}