#if UNITY_EDITOR

#endif
#if UNITY_EDITOR
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build;

namespace VladislavTsurikov.Utility
{
    public static class ScriptingDefineSymbolsUtility
    {
        public static void SetScriptingDefineSymbols(string define)
        {
#if UNITY_6000_0_OR_NEWER
            var buildTarget = NamedBuildTarget.FromBuildTargetGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
            List<string> defineList = new List<string>(PlayerSettings.GetScriptingDefineSymbols(buildTarget).Split(';'));
#else
            List<string> defineList = new List<string>(PlayerSettings.GetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup).Split(';'));
#endif
            if (!defineList.Contains(define))
            {
                defineList.Add(define);
                string defines = string.Join(";", defineList.ToArray());
#if UNITY_6000_0_OR_NEWER
                PlayerSettings.SetScriptingDefineSymbols(buildTarget, defines);
#else
                PlayerSettings.SetScriptingDefineSymbolsForGroup(EditorUserBuildSettings.selectedBuildTargetGroup, defines);
#endif
            }
        }
    }
}
#endif
