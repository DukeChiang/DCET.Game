using UnityEditor;
using ToolRuntime;
using UnityEngine;

namespace ToolEditor
{
    [CustomEditor(typeof(PrefabLightmapData))]
    public class PrefabLightmapDataInspector : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (target)
            {
                var prefabLightmapData = target as PrefabLightmapData;

                if (prefabLightmapData)
                {
                    prefabLightmapData.Set();

                    GUILayout.BeginHorizontal();

                    if (GUILayout.Button("Clear", EditorStyles.miniButtonLeft))
                    {
                        prefabLightmapData.Clear();
                    }

                    if (GUILayout.Button("Save", EditorStyles.miniButtonRight))
                    {
                        prefabLightmapData.Save();
                    }

                    GUILayout.EndHorizontal();
                }
            }
        }
    }
}