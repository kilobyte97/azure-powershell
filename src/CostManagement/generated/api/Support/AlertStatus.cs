// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support
{

    public partial struct AlertStatus :
        System.IEquatable<AlertStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertStatus Active = @"Active";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertStatus Dismissed = @"Dismissed";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertStatus None = @"None";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertStatus Overridden = @"Overridden";

        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertStatus Resolved = @"Resolved";

        /// <summary>the value for an instance of the <see cref="AlertStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AlertStatus" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AlertStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AlertStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AlertStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AlertStatus(System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AlertStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AlertStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AlertStatus && Equals((AlertStatus)obj);
        }

        /// <summary>Returns hashCode for enum AlertStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AlertStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AlertStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AlertStatus" />.</param>

        public static implicit operator AlertStatus(string value)
        {
            return new AlertStatus(value);
        }

        /// <summary>Implicit operator to convert AlertStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AlertStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AlertStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertStatus e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AlertStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertStatus e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.AlertStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}