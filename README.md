# String Compression

This C# library provides a simple string compression algorithm as an extension method. The algorithm counts repeated consecutive characters and compresses the string by representing each group of characters with the count followed by the character itself.

## Features

- Simple and efficient string compression algorithm
- Implemented as an extension method for easy usage
- Optimized for performance using `StringBuilder`

## Installation

1. Clone this repository to your local machine.

        git clone https://github.com/your_username/StringCompression.git

2. Add the `StringCompression.csproj` file to your C# project as a reference or include the `StringExtensions.cs` file in your project.

## Usage

After adding the reference or including the file, you can use the `Compress` extension method on any string as shown below:

```csharp
using StringCompression;

string input = "aaaabbbbaacde";
string compressed = input.Compress();
Console.WriteLine(compressed); // Output: "4a4b2a1c1d1e"
```

## Testing
The library includes a test project using xUnit. To run the tests, navigate to the StringCompression.Tests directory and execute the following command:

    dotnet test
    
## Contributing
Contributions are welcome! If you have any suggestions, improvements or bug reports, please submit a pull request or create an issue.
