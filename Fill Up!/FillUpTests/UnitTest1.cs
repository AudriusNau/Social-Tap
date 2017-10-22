using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace FillUpTests
{
    [TestClass]
    public class LoadDataTest
    {
        [TestMethod]
        public void Readfile_LoadData()
        {
           
            ReadFile readfile = new ReadFile();
            ListsOfBars barList = readfile.LoadData();
            Assert.IsNotNull(barList);
        }
    }
}
