﻿using System;

namespace QuickCommandLine.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class CommandAttribute : Attribute
    {
        public string Name { get; }

        public CommandAttribute(string name)
        {
            Name = name;
        }
    }
}