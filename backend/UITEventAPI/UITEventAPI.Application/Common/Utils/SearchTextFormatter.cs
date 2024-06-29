using System.Text.RegularExpressions;

namespace UITEventAPI.Application.Common.Utils;

public static partial class SearchTextFormatter
{
    public static string FormatSearchTextWithAnd(string searchText)
    {
        if (string.IsNullOrWhiteSpace(searchText))
        {
            return searchText;
        }

        var matches = QuotedPhraseOrWordMatcher().Matches(searchText);

        // Separate quoted and unquoted terms
        var quotedTerms = matches.Cast<Match>()
            .Where(m => m.Groups["phrase"].Success)
            .Select(m => m.Groups["phrase"].Value)
            .ToList();

        var unquotedTerms = matches.Cast<Match>()
            .Where(m => m.Groups["word"].Success)
            .Select(m => m.Groups["word"].Value)
            .ToList();

        // Join quoted phrases with " AND "
        string quotedText = quotedTerms.Count != 0 ? string.Join(" AND ", quotedTerms) : string.Empty;

        // Join unquoted words with " OR "
        string unquotedText = unquotedTerms.Count != 0 ? string.Join(" OR ", unquotedTerms) : string.Empty;

        // Combine both with " OR " if both exist
        if (!string.IsNullOrEmpty(quotedText) && !string.IsNullOrEmpty(unquotedText))
        {
            return $"({quotedText}) OR ({unquotedText})";
        }

        // Return either quotedText or unquotedText if only one exists
        return quotedText + unquotedText; // This handles cases where only one type of term is present
    }

    public static string FormatSearchTextWithOr(string searchText)
    {
        if (string.IsNullOrWhiteSpace(searchText))
        {
            return searchText;
        }

        List<string> terms = ExtractTermsFromSearchText(searchText);

        // Join terms with " OR "
        return string.Join(" OR ", terms);
    }

    private static List<string> ExtractTermsFromSearchText(string searchText)
    {
        var matches = QuotedPhraseOrWordMatcher().Matches(searchText);
        var terms = matches.Cast<Match>()
                           .Select(m => m.Groups["phrase"].Success ? m.Groups["phrase"].Value : m.Groups["word"].Value)
                           .Select(m => m.Trim())
                           .Where(m => !string.IsNullOrEmpty(m))
                           .ToList();

        return terms;
    }

    [GeneratedRegex(@"(?<phrase>""[^""]+"")|(?<word>\S+)")]
    private static partial Regex QuotedPhraseOrWordMatcher();
}
