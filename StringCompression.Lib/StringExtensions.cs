using System.Text;

namespace StringCompression.Lib;

public static class StringExtensions {
    public static string Compress(this string value) {
        if (string.IsNullOrWhiteSpace(value)) return string.Empty;
        int repeatedInstances = 1;
        var resultingValue    = new StringBuilder();
        for (int i = 1; i < value.Length; i++) {
            char currentCharacter = value[i - 1];
            char nextCharacter    = value[i];
            if (currentCharacter == nextCharacter) {
                repeatedInstances++;
            }
            else {
                resultingValue.Append(repeatedInstances);
                resultingValue.Append(currentCharacter);
                repeatedInstances = 1;
            }
        }

        resultingValue.Append(repeatedInstances);
        resultingValue.Append(value[^1]);
        return resultingValue.ToString();
    }
}