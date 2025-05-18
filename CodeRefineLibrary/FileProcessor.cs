using System.Text.RegularExpressions;

namespace CodeRefineLibrary
{
    public static class FileProcessor
    {
        private const string FileTypes = "*.Designer.cs";
        private const string ConditionMatch = ".SetImageKey(";
        public static async Task FindPatternAndProcess(string location, string pattern)
        {
            await Task.Delay(3000);
            var files = Directory.GetFiles(location, FileTypes);

            foreach(var file in files)
            {
                var linesArray = await File.ReadAllLinesAsync(file);
                var linesList = linesArray.ToList();
                bool isFileModified = ProcessFile(linesList, pattern);

                if (isFileModified)
                {
                    await File.WriteAllLinesAsync(file, linesList);
                }
            }
        }

        private static bool ProcessFile(List<string> lines, string pattern)
        {
            bool modified = false;

            for (int i = 0; i < lines.Count; i++)
            {
                var match = Regex.Match(lines[i], pattern, RegexOptions.Compiled);

                if(match.Success)
                {
                    var controlName = match.Groups[1].Value;
                    bool isConditionMet = IsConditionMet(lines, controlName);                       

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

        private static bool IsConditionMet(List<string> lines, string controlToMatch)
        {
            bool conditionMet = false;

            for (int j = 0; j < lines.Count; j++)
            {
                if (lines[j].Contains($"{ConditionMatch}{controlToMatch}"))
                {
                    conditionMet = true;
                    break;
                }
            }

            return conditionMet;
        }
    }
}
