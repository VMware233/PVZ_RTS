﻿#if UNITY_EDITOR
using PVZRTS.GameCore;
using VMFramework.Editor.GameEditor;
using VMFramework.GameLogicArchitecture;

namespace PVZRTS.UI
{
    public partial class EntitySelectionGeneralSetting : IGameEditorMenuTreeNode
    {
        string INameOwner.name => "Entity Selection";
    }
}
#endif