﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VMFramework.Core
{
    [Flags]
    public enum LeftRightDirection
    {
        None = 0,

        Left = 1,

        Right = 2,
        
        All = Left | Right
    }

    [Flags]
    public enum FourTypesDirection2D
    {
        None = 0,

        Up = 1,

        Down = 2,

        Left = 4,

        Right = 8,

        All = Up | Down | Left | Right
    }

    public static class DirectionUtility
    {
        #region Left Right Direction

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LeftRightDirection Reversed(this LeftRightDirection direction)
        {
            var result = LeftRightDirection.None;
            
            if (direction.HasFlag(LeftRightDirection.Left))
            {
                result |= LeftRightDirection.Right;
            }
            
            if (direction.HasFlag(LeftRightDirection.Right))
            {
                result |= LeftRightDirection.Left;
            }
            
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LeftRightDirection ToLeftRightDirection(this float value)
        {
            return value switch
            {
                < 0 => LeftRightDirection.Left,
                > 0 => LeftRightDirection.Right,
                _ => LeftRightDirection.None
            };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LeftRightDirection ToLeftRightDirection(this int value)
        {
            return value switch
            {
                < 0 => LeftRightDirection.Left,
                > 0 => LeftRightDirection.Right,
                _ => LeftRightDirection.None
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int ToInt(
            this LeftRightDirection direction)
        {
            return (int)direction;
        }

        #endregion

        #region Four Types Direction 2D

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static FourTypesDirection2D Reversed(
            this FourTypesDirection2D direction)
        {
            var result = FourTypesDirection2D.None;
            
            if (direction.HasFlag(FourTypesDirection2D.Up))
            {
                result |= FourTypesDirection2D.Down;
            }
            
            if (direction.HasFlag(FourTypesDirection2D.Down))
            {
                result |= FourTypesDirection2D.Up;
            }
            
            if (direction.HasFlag(FourTypesDirection2D.Left))
            {
                result |= FourTypesDirection2D.Right;
            }
            
            if (direction.HasFlag(FourTypesDirection2D.Right))
            {
                result |= FourTypesDirection2D.Left;
            }
            
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static FourTypesDirection2D ToFourTypesDirection2D(
            this Vector2 vector)
        {
            if (vector.x.Abs() > vector.y.Abs())
            {
                return vector.x > 0
                    ? FourTypesDirection2D.Right
                    : FourTypesDirection2D.Left;
            }

            if (vector.y.Abs() > vector.x.Abs())
            {
                return vector.y > 0
                    ? FourTypesDirection2D.Up
                    : FourTypesDirection2D.Down;
            }

            return FourTypesDirection2D.None;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2Int ToCardinalVector(
            this FourTypesDirection2D direction)
        {
            return direction switch
            {
                FourTypesDirection2D.Up => Vector2Int.up,
                FourTypesDirection2D.Down => Vector2Int.down,
                FourTypesDirection2D.Left => Vector2Int.left,
                FourTypesDirection2D.Right => Vector2Int.right,
                _ => throw new ArgumentOutOfRangeException(nameof(direction),
                    direction, null)
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static FourTypesDirection2D GetOtherDirections(
            this FourTypesDirection2D direction)
        {
            return FourTypesDirection2D.All & ~direction;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsHorizontal(this FourTypesDirection2D direction)
        {
            return (direction & (FourTypesDirection2D.Left | FourTypesDirection2D.Right)) !=
                   FourTypesDirection2D.None;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsVertical(this FourTypesDirection2D direction)
        {
            return (direction & (FourTypesDirection2D.Up | FourTypesDirection2D.Down)) !=
                   FourTypesDirection2D.None;
        }

        #endregion
    }
}
