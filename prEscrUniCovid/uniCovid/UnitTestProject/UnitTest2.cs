using Microsoft.VisualStudio.TestTools.UnitTesting;
using uniCovid.Models;
using uniCovid;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {


            drvJSON drv;




            int datos;
            int actualResult;


            drv = new drvJSON();
            drv.origen = "Models/uniCovid.json";
            drv.loadData();


            datos = 594;
            actualResult = drv.getTotal();


            Assert.AreEqual(datos, actualResult);









        }
    }
}
