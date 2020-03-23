using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euclid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Euclid.Tests
{
    [TestClass()]
    public class EuclidAlgorithmsTests
    {
        [TestMethod()]
        public void EuclidGCD_54_36_12_2_Return2()
        {
            EuclidAlgorithms euclidGCD = new EuclidAlgorithms();
            Stopwatch elapsedTicks = new Stopwatch();
            int target = euclidGCD.EuclidGCD(ref elapsedTicks, 54, 36, 12, 2);

            Assert.AreEqual(2, target);  
        }

        [TestMethod()]
        public void EuclidGCD_36_18_12_Return6()
        {
            EuclidAlgorithms euclidGCD = new EuclidAlgorithms();
            Stopwatch elapsedTicks = new Stopwatch();
            int target = euclidGCD.EuclidGCD(ref elapsedTicks, 36, 18, 12);

            Assert.AreEqual(6, target);
        }


        [TestMethod()]
        public void EuclidGCD_30_17_Return1()
        {
            EuclidAlgorithms euclidGCD = new EuclidAlgorithms();
            Stopwatch elapsedTicks = new Stopwatch();
            int target = euclidGCD.EuclidGCD(ref elapsedTicks, 30, 17);

            Assert.AreEqual(1, target);
        }


        [TestMethod()]
        public void BinaryEuclidGCD_121_66_11Return11()
        {
            EuclidAlgorithms euclidGCD = new EuclidAlgorithms();
            Stopwatch elapsedTicks = new Stopwatch();
            int target = euclidGCD.EuclidGCD(ref elapsedTicks, 121, 66, 11);

            Assert.AreEqual(11, target);
        }


        [TestMethod()]
        public void BinaryEuclidGCD_320_108_14Return2()
        {
            EuclidAlgorithms euclidGCD = new EuclidAlgorithms();
            Stopwatch elapsedTicks = new Stopwatch();
            int target = euclidGCD.EuclidGCD(ref elapsedTicks, 320, 108, 14);

            Assert.AreEqual(2, target);
        }


        [TestMethod()]
        public void BinaryEuclidGCD_540_72_Return36()
        {
            EuclidAlgorithms euclidGCD = new EuclidAlgorithms();
            Stopwatch elapsedTicks = new Stopwatch();
            int target = euclidGCD.EuclidGCD(ref elapsedTicks, 540, 72, 36);

            Assert.AreEqual(36, target);
        }
    }
}