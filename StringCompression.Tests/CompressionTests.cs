using StringCompression.Lib;

namespace StringCompression.Tests;

public class CompressionTests {
    [Theory]
    [InlineData("aaaabbbbaacde",     "4a4b2a1c1d1e")]
    [InlineData("aaa",               "3a")]
    [InlineData("bbbbbb",            "6b")]
    [InlineData("abbbbbbc",          "1a6b1c")]
    [InlineData("aaabccc",           "3a1b3c")]
    [InlineData("hhellllllllooooo!", "2h1e8l5o1!")]
    [InlineData("woorrrllllddddd",   "1w2o3r4l5d")]
    public void CompressionTest(string originalValue, string expectedResult) {
        string resultingValue = originalValue.Compress();
        Assert.Equal(expectedResult, resultingValue);
    }
}