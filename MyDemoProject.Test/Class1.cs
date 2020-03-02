using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyDemoProject;

namespace MyDemoProject.Test
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public static void Test1()
        {
            //arrange
            Program p1 = new Program();
            //act
            int actualresult = p1.Add(5, 10);
            //assert
            Assert.That(actualresult, Is.EqualTo(15)); //15 is expected answer
        }

        [Test]
        public static void Test2()
        {
            //arrange
            Program p2 = new Program();
            //act
            int actualresult = p2.Add(5, 10);
            //assert
            Assert.That(actualresult, Is.EqualTo(25)); //15 is expected answer
        }
    }
}
