# Frends Community PDF Tasks

This repository contains **Frends Community PDF tasks** for working with PDF documents in the Frends platform.

[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)

## Available Tasks

This repository includes two separate NuGet packages:

- **[Frends.Community.PdfMerge](#frends-community-pdf-merge)** - Merge multiple PDF files into one
- **[Frends.Community.PdfSplitter](#frends-community-pdf-splitter)** - Split PDF files into individual pages

## Installing

You can install either task via Frends UI Task View or NuGet Package Manager:

```bash
# Install PDF Merge functionality
Install-Package Frends.Community.PdfMerge

# Install PDF Splitter functionality  
Install-Package Frends.Community.PdfSplitter
```

---

# Frends Community PDF Merge

Merge multiple PDF files into a single document.

## MergePages Task

### Parameters

| Property    | Type         | Description                              | Example                       |
|-------------|--------------|------------------------------------------|-------------------------------|
| PageBytes   | List<byte[]> | List of PDF file contents as byte arrays | File.ReadAllBytes("file1.pdf") |

### Result

| Property        | Type     | Description                      | Example                       |
|-----------------|----------|----------------------------------|-------------------------------|
| OutputFileBytes | byte[]   | Merged PDF file as byte array    | result.OutputFileBytes         |

---

# Frends Community PDF Splitter

Split PDF files into individual pages as separate documents.

## SplitPages Task

### Parameters

| Property | Type   | Description                | Example           |
|----------|--------|----------------------------|-------------------|
| Path     | string | Full path to PDF file      | "C:\\temp\\doc.pdf" |

### Result

| Property | Type          | Description                           | Example           |
|----------|---------------|---------------------------------------|-------------------|
| Output   | List<byte[]>  | List of split pages as byte arrays    | result.Output[0]  |

---

## Building

### Clone the repository

```bash
git clone https://github.com/FrendsPlatform/Frends.Community.Netum.git
cd Frends.Community.Netum
```

### Build all projects

```bash
dotnet build Frends.Community.Netum.sln
```

### Run tests

```bash
dotnet test Frends.Community.Netum.sln
```

### Create NuGet packages

```bash
# Build both packages
dotnet pack Frends.Community.PdfMerge --configuration Release
dotnet pack Frends.Community.PdfSplitter --configuration Release
```

## Project Structure

```
Frends.Community.Netum/
├── Frends.Community.PdfMerge/              # PDF merging functionality
├── Frends.Community.PdfMerge.Tests/        # Tests for merge functionality
├── Frends.Community.PdfSplitter/           # PDF splitting functionality
├── Frends.Community.PdfSplitter.Tests/     # Tests for splitter functionality
└── Frends.Community.Netum.sln              # Solution file
```

## Third Party Licenses

- This project is licensed under the MIT License - see the LICENSE file for details
- Uses [PdfSharp](https://github.com/empira/PDFsharp) library for PDF manipulation

## Changelog

| Version | Date       | Task      | Description                    |
|---------|------------|-----------|--------------------------------|
| 1.0.0   | 2025-06-11 | PdfMerge  | Initial version of MergePDF    |
| 1.0.0   | 2026-04-17 | PdfSplitter | Initial version of SplitPages |