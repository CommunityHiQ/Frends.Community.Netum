# Frends.Community.PDFMerger
This Frends task can merge multiple PDFs into one.

[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)

## Installing

You can install the Task via Frends UI Task View.

# Tasks
## MergePages
### Task Parameters

| Property    | Type         | Description                              | Example                       |
|-------------|--------------|------------------------------------------|-------------------------------|
| PageBytes   | List<byte[]> | List of PDF file contents as byte arrays | File.ReadAllBytes("file1.pdf") |

### Result

| Property        | Type     | Description                      | Example                       |
|-----------------|----------|----------------------------------|-------------------------------|
| OutputFileBytes | byte[]   | Merged PDF file as byte array    | result.OutputFileBytes         |


## Building

### Clone a copy of the repository

`git clone https://github.com/FrendsPlatform/Frends.PDF.git`

### Build the project

`dotnet build`

### Run tests

Run the tests

`dotnet test`

### Create a NuGet package

`dotnet pack --configuration Release`

### Third party licenses

This project is licensed under the MIT License - see the LICENSE file for details.

## Changelog

| Version | Date       | Description                |
|---------|------------|----------------------------|
| 1.0.0   | 2025-06-11 | Initial version of MergePDF|