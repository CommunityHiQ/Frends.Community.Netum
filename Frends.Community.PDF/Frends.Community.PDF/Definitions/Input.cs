namespace Frends.Community.PDF.Definitions;

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Input class usually contains parameters that are required.
/// </summary>
public class Input
{
    /// <summary>
    /// Something that will be repeated.
    /// </summary>
    /// <example>Some example of the expected value</example>
    [DisplayName("PDF file")]
    [DisplayFormat(DataFormatString = "Expression")]
    [DefaultValue("")]
    public List<byte[]> PageBytes { get; set; }
}