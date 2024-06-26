﻿#if UNITY_EDITOR
using Sirenix.OdinInspector;
using VMFramework.Editor;
using VMFramework.Editor.GameEditor;
using VMFramework.GameLogicArchitecture;
using VMFramework.Localization;

namespace VMFramework.ResourcesManagement
{
    public partial class SpriteGeneralSetting : IGameEditorMenuTreeNode
    {
        string INameOwner.name => "Sprite Preset";

        Icon IGameEditorMenuTreeNode.icon => SdfIconType.CardImage;

        string IGameEditorMenuTreeNode.folderPath => GameEditorNames.RESOURCES_MANAGEMENT_CATEGORY;
    }
}
#endif