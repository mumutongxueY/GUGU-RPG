﻿using UnityEditor;
using UnityEditor.Callbacks;

namespace RPG.EventSystem
{
    public class NodeEditorMenu
    {
        [OnOpenAsset(1)]
        public static bool OpenWindow(int instanceID,int line)
        {
            var obj = EditorUtility.InstanceIDToObject(instanceID);
            if(obj is EventGraph graph)
            {
                EventGraphWindow.OpenWindow(graph);
                return true;
            }
            return false;
        }
    }
}

