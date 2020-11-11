// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using NUnit.Framework;
using NUnitLite;

namespace Snippets
{
    public class Program
    {
        static void Main(
            string region = null,
            string session = null,
            string package = null,
            string project = null,
            string[] args = null)
        {
            #region Main
            switch (region)
            {
                case "run":
                    Run();
                    break;
                case "run1":
                    Run1();
                    break;
                case "run2":
                    Run2();
                    break;
                case "run3":
                    Run3();
                    break;
                case "nunitContent":
                    RunNUnit();
                    break;
            }
        }
        #endregion

        public static void Run()
        {
            #region run
            Console.WriteLine("Hello World!");
            #endregion
        }

        public static void Run1()
        {
            #region run1
            Console.WriteLine(DateTime.Now);
            #endregion
        }

        public static void Run2()
        {
            #region run2
            Console.WriteLine(Guid.NewGuid());
            #endregion
        }

        public static void Run3()
        {
            #region run3
            #endregion
        }

        public static void RunNUnit()
        {
            new AutoRun().Execute(new string[] { });
        }
    }

    public class BasicTest
    {
        #region nunitContent
        [Test]
        public void Testing123()
        {
            var sut = 1 + 2;

            Assert.That(sut, Is.EqualTo(3));
        }
        #endregion

    }
}