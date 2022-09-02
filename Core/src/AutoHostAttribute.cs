using System;

namespace AutoHost
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class AutoHostAttribute : Attribute
    {
    }
}