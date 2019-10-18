// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNetCore.Testing
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = true)]
    public class TestOutputDirectoryAttribute : Attribute
    {
        public TestOutputDirectoryAttribute(string targetFramework, string baseDirectory = null)
        {
            TargetFramework = targetFramework;
            BaseDirectory = baseDirectory;
        }

        public string BaseDirectory { get; }
        public string TargetFramework { get; }
    }
}