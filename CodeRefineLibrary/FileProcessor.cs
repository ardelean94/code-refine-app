using System.Text.RegularExpressions;

namespace CodeRefineLibrary
{
    public static class FileProcessor
    {
        public static async Task FindPatternAndProcess(string location, string fileType, 
            string conditionMatch, string patternToRemove)
        {
            var files = Directory.GetFiles(location, fileType);

            foreach(var file in files)
            {
                var linesArray = await File.ReadAllLinesAsync(file);
                var linesList = linesArray.ToList();
                bool isFileModified = ProcessFile(linesList, conditionMatch, patternToRemove);

                if (isFileModified)
                {
                    await File.WriteAllLinesAsync(file, linesList);
                }
            }
        }

        private static bool ProcessFile(List<string> lines, string conditionMatch, string pattern)
        {
            bool modified = false;

            for (int i = 0; i < lines.Count; i++)
            {
                var match = Regex.Match(lines[i], pattern, RegexOptions.Compiled);

                if(match.Success)
                {
                    var controlName = match.Groups[1].Value;
                    bool isConditionMet = IsConditionMet(lines, conditionMatch, controlName);                       

                    if (isConditionMet)
                    {
                        lines.RemoveAt(i);
                        modified = true;
                        i--;
                    }
                }
            }

            return modified;
        }

        private static bool IsConditionMet(List<string> lines, string conditionMatch, string controlToMatch)
        {
            bool conditionMet = false;

            for (int j = 0; j < lines.Count; j++)
            {
                if (lines[j].Contains($"{conditionMatch}{controlToMatch}"))
                {
                    conditionMet = true;
                    break;
                }
            }

            return conditionMet;
        }
    }
}
