using System.Text.RegularExpressions;

namespace CodeRefineLibrary
{
    public static class FileProcessor
    {
        private const string FileTypes = "*.Designer.cs";
        private const string ConditionMatch = ".SetImageKey(";
        public static void FindPatternAndProcess(string location, string pattern)
        {
            var files = Directory.GetFiles(location, FileTypes);

            foreach(var file in files)
            {
                var lines = File.ReadAllLines(file).ToList();
                bool isFileModified = ProcessFile(lines, pattern);

                if (isFileModified)
                {
                    File.WriteAllLines(file, lines);
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
