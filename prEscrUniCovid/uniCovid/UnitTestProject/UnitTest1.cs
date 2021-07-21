using Microsoft.VisualStudio.TestTools.UnitTesting;
using uniCovid.Models;
using uniCovid;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


            drvJSON drv;
           

         
            
            int headers;
            int actualResult;


            drv = new drvJSON();
            drv.origen = "Models/uniCovid.json";
            drv.loadData();
            

            headers = 4;
            actualResult = drv.getTotalKeys();


            Assert.AreEqual(headers, actualResult);









        }
    }
}
