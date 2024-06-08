﻿#if UNITY_EDITOR && ODIN_INSPECTOR
using Sirenix.OdinInspector;

namespace VMFramework.Core.Pool
{
    public partial class LimitedArrayReferencePool<TItem>
    {
        [ShowInInspector]
        private TItem[] poolDebug => pool;
    }
}
#endif