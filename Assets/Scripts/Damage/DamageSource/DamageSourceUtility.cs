﻿using FishNet.Object;
using UnityEngine;

namespace PVZRTS.Damage
{
    public static class DamageSourceUtility
    {
        /// <summary>
        /// 强制对目标造成伤害
        /// 仅在服务器上有效
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        [Server]
        public static void ForceTakeDamage(this IDamageSource source, IDamageable target)
        {
            if (target == null)
            {
                return;
            }

            source.ProduceDamagePacket(target, out var packet);
            target.ReceiveDamagePacket(packet);
        }

        /// <summary>
        /// 请求对目标造成伤害
        /// 仅在服务器上有效
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        public static void RequestTakeDamage(this IDamageSource source, IDamageable target)
        {
            if (source == null)
            {
                Debug.LogWarning("Source is null.");
                return;
            }
            
            if (target == null)
            {
                return;
            }

            if (source.CanDamage(target) == false)
            {
                return;
            }

            if (target.CanBeDamaged(source) == false)
            {
                return;
            }

            source.ForceTakeDamage(target);
        }
    }
}