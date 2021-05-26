// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>Permissions for the key -- read-only or full permissions.</summary>
    public partial struct KeyPermission :
        System.IEquatable<KeyPermission>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyPermission Full = @"Full";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyPermission Read = @"Read";

        /// <summary>the value for an instance of the <see cref="KeyPermission" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to KeyPermission</summary>
        /// <param name="value">the value to convert to an instance of <see cref="KeyPermission" />.</param>
        internal static object CreateFrom(object value)
        {
            return new KeyPermission(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type KeyPermission</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyPermission e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type KeyPermission (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is KeyPermission && Equals((KeyPermission)obj);
        }

        /// <summary>Returns hashCode for enum KeyPermission</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="KeyPermission" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private KeyPermission(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for KeyPermission</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to KeyPermission</summary>
        /// <param name="value">the value to convert to an instance of <see cref="KeyPermission" />.</param>

        public static implicit operator KeyPermission(string value)
        {
            return new KeyPermission(value);
        }

        /// <summary>Implicit operator to convert KeyPermission to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="KeyPermission" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyPermission e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum KeyPermission</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyPermission e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyPermission e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum KeyPermission</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyPermission e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyPermission e2)
        {
            return e2.Equals(e1);
        }
    }
}