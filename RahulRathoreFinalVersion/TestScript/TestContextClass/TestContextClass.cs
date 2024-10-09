using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RahulRathoreFinalVersion.TestScript.TestContextClass
{
    public class TestContextClass
    {
      //  private TestContext _testContext;

        /*public TestContext TestContext1
        {
            get {return _testContext;}
            set { _testContext = value; }
        }*/

        [Test]
        public void TestCase1()
        {
            Console.WriteLine(TestContext.CurrentContext.Test.Name);
            
        }

        [Test]
        public void TestCase2()
        {
            Console.WriteLine(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]

        public void TestCaseTearDown()
        {
            Console.WriteLine(TestContext.CurrentContext.Result.Outcome);
        }

    }
}
