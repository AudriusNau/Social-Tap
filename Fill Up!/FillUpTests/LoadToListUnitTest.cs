using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Fill_Up_;
using Fill_Up_.Fill_Up_;

namespace FillUpTests
{
    [TestClass]
    public class LoadDataTest
    {
        [TestMethod]
        public void Readfile_LoadData()
        {
            ListsOfBars barList = new ListsOfBars();
            ReadFile t = new ReadFile();
            t.LoadToList(barList, "name", 4, 1, 2, 3);
            Assert.IsNotNull(barList);
        }
    }
}
