﻿#region copyright
// -----------------------------------------------------------------------
//  <copyright file="GuidTest.cs" company="Akka.NET Team">
//      Copyright (C) 2015-2016 AsynkronIT <https://github.com/AsynkronIT>
//      Copyright (C) 2016-2016 Akka.NET Team <https://github.com/akkadotnet>
//  </copyright>
// -----------------------------------------------------------------------
#endregion

using System;

namespace Hyperion.PerfTest.Tests
{
    class GuidTest : TestBase<Guid>
    {
        protected override Guid GetValue()
        {
            return Guid.NewGuid();
        }
    }
}
