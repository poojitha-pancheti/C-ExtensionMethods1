﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExxtensionMethods.Library
{
    public class EnumerableTests
    {
        IEnumerable<string> _strings;
        [SetUp]
        public void SetUp()
        {
            _strings= new List<string> { "a", "b", "c" };
        }
        [Test]
        public void Count()
        {
            Assert.AreEqual(3, _strings.Count());
        }
    }
}