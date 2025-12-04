#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.IO;
using System.Text.RegularExpressions;

public static class StripCommentsEditor
{
    [MenuItem("Tools/Strip Comments From Scripts")] 
    public static void StripCommentsFromAllScripts()
    {
        string assetsPath = Application.dataPath;
        var files = Directory.GetFiles(assetsPath, "*.cs", SearchOption.AllDirectories);
        int changed = 0;

        // regex for block comments and line comments
        var blockComment = new Regex(@"/\*.*?\*/", RegexOptions.Singleline);
        var lineComment = new Regex(@"//.*?$", RegexOptions.Multiline);

        foreach (var file in files)
        {
            // Skip this editor file to avoid removing its comments (optional)
            if (file.EndsWith("StripCommentsEditor.cs"))
                continue;

            string text = File.ReadAllText(file);
            string processed = blockComment.Replace(text, "");
            processed = lineComment.Replace(processed, "");

            if (processed != text)
            {
                File.WriteAllText(file, processed);
                changed++;
            }
        }

        AssetDatabase.Refresh();
        Debug.Log($"StripComments: processed {files.Length} files, modified {changed} files.");
    }
}
#endif