using UnityEditor;
using ToolRuntime;
using UnityEngine;

namespace ToolEditor
{
    [CustomEditor(typeof(CameraDepthTexture))]
    public class CameraDepthTextureInspector : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (target)
            {
                var cameraDepthTexture = target as CameraDepthTexture;

                if (cameraDepthTexture)
                {
                    var camera = cameraDepthTexture.GetComponent<Camera>();

                    if(camera && camera.depthTextureMode != cameraDepthTexture.depthTextureMode)
                    {
                        cameraDepthTexture.Start();
                    }
                }
            }
        }
    }
}