using Microsoft.VisualStudio.TestTools.UnitTesting;
using uniCovid.Models;
using uniCovid;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {


            drvJSON drv;




            int datos;
            int actualResult;


            drv = new drvJSON();
            drv.origen = "Models/uniCovid.json";


            Assert.IsTrue(drv.loadData());









        }
    }
}
