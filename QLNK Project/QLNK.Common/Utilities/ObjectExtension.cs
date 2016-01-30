﻿using System.ComponentModel;
using System.Reflection;

namespace QLNK.Common.Utilities
{
    public static class ObjectExtension
    {
        public static string DescriptionAttr<T>(this T source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0) return attributes[0].Description;
            return source.ToString();
        }

    }


}
