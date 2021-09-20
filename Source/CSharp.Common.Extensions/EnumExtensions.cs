using System;
using System.ComponentModel;

namespace CSharp.Common.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="Enum"/>.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Retrieves the Description value via the <see cref="DescriptionAttribute"/>.
        /// </summary>
        /// <typeparam name="T">The type of enum the value pertains to.</typeparam>
        /// <param name="enumValue">The target enumeration value.</param>
        /// <returns/>
        public static string GetDescription<T>(this T enumValue) where T : struct
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
            var attr = Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute));
            return attr == null ? string.Empty : ((DescriptionAttribute)attr).Description;
        }
    }
}
