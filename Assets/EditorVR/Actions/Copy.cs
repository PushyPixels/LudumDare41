﻿#if UNITY_EDITOR
namespace UnityEditor.Experimental.EditorVR.Actions
{
    [ActionMenuItem("Copy", ActionMenuItemAttribute.DefaultActionSectionName, 5)]
    sealed class Copy : BaseAction
    {
        public override void ExecuteAction()
        {
            Unsupported.CopyGameObjectsToPasteboard();
            Paste.SetBufferDistance(Selection.transforms);
        }
    }
}
#endif
