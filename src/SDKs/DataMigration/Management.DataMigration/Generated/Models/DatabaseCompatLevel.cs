// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DatabaseCompatLevel.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DatabaseCompatLevel
    {
        [EnumMember(Value = "CompatLevel80")]
        CompatLevel80,
        [EnumMember(Value = "CompatLevel90")]
        CompatLevel90,
        [EnumMember(Value = "CompatLevel100")]
        CompatLevel100,
        [EnumMember(Value = "CompatLevel110")]
        CompatLevel110,
        [EnumMember(Value = "CompatLevel120")]
        CompatLevel120,
        [EnumMember(Value = "CompatLevel130")]
        CompatLevel130,
        [EnumMember(Value = "CompatLevel140")]
        CompatLevel140
    }
    internal static class DatabaseCompatLevelEnumExtension
    {
        internal static string ToSerializedValue(this DatabaseCompatLevel? value)
        {
            return value == null ? null : ((DatabaseCompatLevel)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DatabaseCompatLevel value)
        {
            switch( value )
            {
                case DatabaseCompatLevel.CompatLevel80:
                    return "CompatLevel80";
                case DatabaseCompatLevel.CompatLevel90:
                    return "CompatLevel90";
                case DatabaseCompatLevel.CompatLevel100:
                    return "CompatLevel100";
                case DatabaseCompatLevel.CompatLevel110:
                    return "CompatLevel110";
                case DatabaseCompatLevel.CompatLevel120:
                    return "CompatLevel120";
                case DatabaseCompatLevel.CompatLevel130:
                    return "CompatLevel130";
                case DatabaseCompatLevel.CompatLevel140:
                    return "CompatLevel140";
            }
            return null;
        }

        internal static DatabaseCompatLevel? ParseDatabaseCompatLevel(this string value)
        {
            switch( value )
            {
                case "CompatLevel80":
                    return DatabaseCompatLevel.CompatLevel80;
                case "CompatLevel90":
                    return DatabaseCompatLevel.CompatLevel90;
                case "CompatLevel100":
                    return DatabaseCompatLevel.CompatLevel100;
                case "CompatLevel110":
                    return DatabaseCompatLevel.CompatLevel110;
                case "CompatLevel120":
                    return DatabaseCompatLevel.CompatLevel120;
                case "CompatLevel130":
                    return DatabaseCompatLevel.CompatLevel130;
                case "CompatLevel140":
                    return DatabaseCompatLevel.CompatLevel140;
            }
            return null;
        }
    }
}
