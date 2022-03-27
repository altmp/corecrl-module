﻿using System;
using AltV.Net.Elements.Args;
using AltV.Net.ObjectMethodExecutors;

namespace AltV.Net
{
    public static partial class Alt
    {
        public static void RegisterMValueAdapter<T>(IMValueAdapter<T> adapter)
        {
            Core.RegisterMValueAdapter(adapter);
        }

        public static bool ToMValue(object obj, Type type, out MValueConst mValue)
        {
            return Core.ToMValue(obj, type, out mValue);
        }

        public static bool FromMValue(in MValueConst mValue, Type type, out object obj)
        {
            return Core.FromMValue(mValue, type, out obj);
        }

        public static bool MValueFromObject(object obj, Type type, out object result)
        {
            return Core.MValueFromObject(obj, type, out result);
        }

        public static bool IsMValueConvertible(Type type)
        {
            return Core.IsMValueConvertible(type);
        }
    }
}