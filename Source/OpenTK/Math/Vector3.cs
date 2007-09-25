﻿#region --- License ---
/* Copyright (c) 2006, 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Math
{
    /// <summary>
    /// Represents a three-dimensional vector.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector3
    {
        #region Fields

        /// <summary>
        /// The X component of the Vector3.
        /// </summary>
        public float X;

        /// <summary>
        /// The Y component of the Vector3.
        /// </summary>
        public float Y;

        /// <summary>
        /// The Z component of the Vector3.
        /// </summary>
        public float Z;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new Vector3.
        /// </summary>
        /// <param name="x">The x component of the Vector3.</param>
        /// <param name="y">The y component of the Vector3.</param>
        /// <param name="z">The z component of the Vector3.</param>
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Constructs a new Vector3 from the given Vector2.
        /// </summary>
        /// <param name="v">The Vector2 to copy components from.</param>
        public Vector3(Vector2 v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0.0f;
        }

        /// <summary>
        /// Constructs a new Vector3 from the given Vector3.
        /// </summary>
        /// <param name="v">The Vector3 to copy components from.</param>
        public Vector3(Vector3 v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
        }

        /// <summary>
        /// Constructs a new Vector3 from the given Vector4.
        /// </summary>
        /// <param name="v">The Vector4 to copy components from.</param>
        public Vector3(Vector4 v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
        }

        #endregion

        #region Functions

        #region Add

        /// <summary>
        /// Adds the given Vector2 to the current Vector3.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector3 containing the result of the addition.</returns>
        public Vector3 Add(Vector2 right)
        {
            return new Vector3(X + right.X, Y + right.Y, Z);
        }

        /// <summary>
        /// Adds the given Vector3 to the current Vector3.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector3 containing the result of the addition.</returns>
        public Vector3 Add(Vector3 right)
        {
            return new Vector3(X + right.X, Y + right.Y, Z + right.Z);
        }

        /// <summary>
        /// Adds the given Vector4 to the current Vector3. W-coordinate remains unaffected.
        /// </summary>
        /// <param name="right">The right operand of the addition.</param>
        /// <returns>A new Vector4 containing the result of the addition.</returns>
        public Vector4 Add(Vector4 right)
        {
            return new Vector4(X + right.X, Y + right.Y, Z + right.Z, right.W);
        }

        #endregion

        #region Sub

        /// <summary>
        /// Subtracts the given Vector2 from the current Vector3.
        /// </summary>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <returns>A new Vector3 containing the result of the subtraction.</returns>
        public Vector3 Sub(Vector2 right)
        {
            return new Vector3(X - right.X, Y - right.Y, Z);
        }

        /// <summary>
        /// Subtracts the given Vector3 from the current Vector3.
        /// </summary>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <returns>A new Vector3 containing the result of the subtraction.</returns>
        public Vector3 Sub(Vector3 right)
        {
            return new Vector3(X - right.X, Y - right.Y, Z - right.Z);
        }

        /// <summary>
        /// Subtracts the given Vector4 from the current Vector3.
        /// </summary>
        /// <param name="right">The right operand of the subtraction.</param>
        /// <returns>A new Vector4 containing the result of the subtraction.</returns>
        public Vector4 Sub(Vector4 right)
        {
            return new Vector4(X - right.X, Y - right.Y, Z - right.Z, -right.W);
        }

        #endregion

        #region Dot

        /// <summary>
        /// Computes the dot product between the current Vector3 and the given Vector2.
        /// </summary>
        /// <param name="right">The right operand of the dot product.</param>
        /// <returns>A float containing the result of the dot product.</returns>
        public float Dot(Vector2 right)
        {
            return X * right.X + Y * right.Y;
        }

        /// <summary>
        /// Computes the dot product between the current Vector3 and the given Vector3.
        /// </summary>
        /// <param name="right">The right operand of the dot product.</param>
        /// <returns>A float containing the result of the dot product.</returns>
        public float Dot(Vector3 right)
        {
            return X * right.X + Y * right.Y + Z * right.Z;
        }

        /// <summary>
        /// Computes the dot product between the current Vector3 and the given Vector4.
        /// </summary>
        /// <param name="right">The right operand of the dot product.</param>
        /// <returns>A float containing the result of the dot product.</returns>
        public float Dot(Vector4 right)
        {
            return X * right.X + Y * right.Y + Z * right.Z;
        }

        #endregion

        #region Cross

        /// <summary>
        /// Computes the cross product between the current and the given Vector3.
        /// </summary>
        /// <param name="right">The right operand of the cross product</param>
        /// <returns>A new Vector3 containing the result of the computation.</returns>
        public Vector3 Cross(Vector3 right)
        {
            return new Vector3(
                Y * right.Z - Z * right.Y,
                Z * right.X - X * right.Z,
                X * right.Y - Y * right.X);
        }

        #endregion

        #region public float Length

        /// <summary>
        /// Gets the length of the vector.
        /// </summary>
        public float Length
        {
            get
            {
                return (float)System.Math.Sqrt(this.LengthSquared);
            }
        }

        #endregion

        #region public float LengthSquared

        /// <summary>
        /// Gets the square of the vector length.
        /// </summary>
        public float LengthSquared
        {
            get
            {
                return X * X + Y * Y + Z * Z;
            }
        }

        #endregion

        #region public Vector3 Normalize()

        /// <summary>
        /// Scales the Vector3 to unit length.
        /// </summary>
        /// <returns>The normalized version of the current vector.</returns>
        public Vector3 Normalize()
        {
            float length = this.Length;
            return new Vector3(X / length, Y / Length, Z / length);
        }

        #endregion

        #region public Vector3 Scale(float sx, float sy, float sz)

        /// <summary>
        /// Scales the current Vector3 by the given amounts.
        /// </summary>
        /// <param name="sx">The scale of the X component.</param>
        /// <param name="sy">The scale of the Y component.</param>
        /// <param name="sz">The scale of the Z component.</param>
        /// <returns>A new, scaled Vector3.</returns>
        public Vector3 Scale(float sx, float sy, float sz)
        {
            return new Vector3(X * sx, Y * sy, Z * sz);
        }

        #endregion

        #endregion

        #region Operator overloads

        public static Vector3 operator +(Vector3 left, Vector2 right)
        {
            return left.Add(right);
        }

        public static Vector3 operator +(Vector3 left, Vector3 right)
        {
            return left.Add(right);
        }

        public static Vector4 operator +(Vector3 left, Vector4 right)
        {
            return left.Add(right);
        }

        public static Vector3 operator -(Vector3 left, Vector2 right)
        {
            return left.Sub(right);
        }

        public static Vector3 operator -(Vector3 left, Vector3 right)
        {
            return left.Sub(right);
        }

        public static Vector4 operator -(Vector3 left, Vector4 right)
        {
            return left.Sub(right);
        }

        [CLSCompliant(false)]
        unsafe public static implicit operator float*(Vector3 v)
        {
            return &v.X;
        }

        #endregion

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", X, Y, Z);
        }
    }
}
