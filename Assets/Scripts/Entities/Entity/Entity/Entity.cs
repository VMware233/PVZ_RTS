﻿using FishNet.Serializing;
using UnityEngine;
using VMFramework.GameLogicArchitecture;

namespace PVZRTS.Entities
{
    public partial class Entity : VisualGameItem, IEntity
    {
        protected IEntityConfig entityConfig => (IEntityConfig)gamePrefab;
        
        public IEntityController controller { get; private set; }

        public GameObject prefab => entityConfig.prefab;

        public void Init(IEntityController entityController)
        {
            controller = entityController;
            
            OnInit();
        }

        protected virtual void OnInit()
        {
            
        }

        #region Network Serialization

        protected override void OnWrite(Writer writer)
        {
            base.OnWrite(writer);
            
            writer.WriteString(uuid);
        }

        protected override void OnRead(Reader reader)
        {
            base.OnRead(reader);
            
            uuid = reader.ReadString();
        }

        #endregion
    }
}