// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support
{

    public partial struct RecurrenceType :
        System.IEquatable<RecurrenceType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.RecurrenceType Annually = @"Annually";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.RecurrenceType Daily = @"Daily";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.RecurrenceType Monthly = @"Monthly";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.RecurrenceType Weekly = @"Weekly";

        /// <summary>the value for an instance of the <see cref="RecurrenceType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to RecurrenceType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RecurrenceType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new RecurrenceType(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type RecurrenceType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.RecurrenceType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type RecurrenceType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is RecurrenceType && Equals((RecurrenceType)obj);
        }

        /// <summary>Returns hashCode for enum RecurrenceType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="RecurrenceType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private RecurrenceType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for RecurrenceType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to RecurrenceType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="RecurrenceType" />.</param>

        public static implicit operator RecurrenceType(string value)
        {
            return new RecurrenceType(value);
        }

        /// <summary>Implicit operator to convert RecurrenceType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="RecurrenceType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.RecurrenceType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum RecurrenceType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.RecurrenceType e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.RecurrenceType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum RecurrenceType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.RecurrenceType e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.RecurrenceType e2)
        {
            return e2.Equals(e1);
        }
    }
}