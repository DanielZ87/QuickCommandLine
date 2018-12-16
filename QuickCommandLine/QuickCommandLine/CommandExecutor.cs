using System;
using System.Collections.Generic;
using System.Reflection;

namespace QuickCommandLine
{
    public class CommandExecutor
    {
        public void Register(params object[] commandOwners)
        {
            if (commandOwners == null)
            {
                throw new ArgumentNullException(nameof(commandOwners));
            }
        }
    }

    internal class CommandOwner
    {
        public object Instance { get; }
        public Dictionary<string, MethodInfo> Commands { get; }

        public CommandOwner(object instance)
        {
            Instance = instance;
        }
    }

    internal class Command
    {
        public MethodInfo Method { get; }
        public int NumberOfParameters { get; }
        public Command(MethodInfo method)
        {
            Method = method;
            NumberOfParameters = method.GetParameters().Length;
        }
    }
}