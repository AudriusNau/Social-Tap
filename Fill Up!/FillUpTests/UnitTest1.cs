using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace FillUpTests
{
    [TestClass]
    public class LoadDataTest
    {
        [TestMethod]
        public void LoadData()
        {
           
            ReadFile readfile = new ReadFile();
            List<Bar> barList = readfile.LoadData<Bar>();
            Assert.IsNotNull(barList);
        }
    }
}
