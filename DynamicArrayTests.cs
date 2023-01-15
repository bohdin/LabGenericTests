using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabGeneric;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabGeneric.Tests
{
    [TestClass()]
    public class DynamicArrayTests
    {
        [TestMethod()]
        public void AddTest()
        {
            DynamicArray<int> controller = new DynamicArray<int>();

            controller.Add(1);
            var res = controller[0];

            Assert.AreEqual(1, res);
        }

        [TestMethod()]
        public void InsertTest()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            controller.Insert(3, 0);
            var res = controller[3];

            Assert.AreEqual(0, controller[3]);
        }

        [TestMethod()]
        public void InsertTest1()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.Insert(10, 0));
        }

        [TestMethod()]
        public void InsertTest2()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            controller.Insert(4, 0);
            var res = controller[4];

            Assert.AreEqual(0, res);
        }

        [TestMethod()]
        public void InsertTest3()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            controller.Insert(0, 0);
            var res = controller[0];

            Assert.AreEqual(0, res);
        }

        [TestMethod()]
        public void InsertRangeTest()
        {
            int[] input = new int[] { 5, 6, 7 };
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            var res = controller;
            res.InsertRange(4, input);

            Assert.AreEqual(7, res[6]);
        }
        [TestMethod()]
        public void InsertRangeTest2()
        {
            int[] input = new int[] { 5, 6, 7 };
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            var res = controller;
            res.InsertRange(2, input);

            Assert.AreEqual(5, res[2]);
        }
        [TestMethod()]
        public void InsertRangeTest3()
        {
            int[] input = new int[] { 5, 6, 7 };
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            var res = controller;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => res.InsertRange(27, input));
        }
        [TestMethod()]
        public void InsertRangeTest4()
        {
            int[] input = null;
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            var res = controller;

            Assert.ThrowsException<ArgumentNullException>(() => res.InsertRange(1, input));
        }
        [TestMethod()]
        public void RemoveTest()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            controller.Remove(1);
            var res = controller[0];

            Assert.AreNotEqual(1, res);
        }

        [TestMethod()]
        public void RemoveTest1()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2};

            controller.Remove(2);
            var res = controller;

            Assert.AreNotEqual(2, res.Count);
        }

        [TestMethod()]
        public void RemoveTest2()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            var res = controller.Remove(100);

            Assert.IsFalse(res);
        }

        [TestMethod()]
        public void RemoveTest3()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1 };

            var res = controller;
            res.Remove(1);

            Assert.IsTrue(res.IsEmpty);
        }
        [TestMethod()]
        public void RemoveAtTest()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            controller.RemoveAt(0);
            var res = controller[0];

            Assert.AreNotEqual(1, res);
        }

        [TestMethod()]
        public void RemoveAtTest1()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            controller.RemoveAt(3);
            var res = controller;

            Assert.AreNotEqual(4, res.Count);
        }

        [TestMethod()]
        public void RemoveAtTest2()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            controller.RemoveAt(2);
            var res = controller[2];

            Assert.AreNotEqual(3, res);
        }

        [TestMethod()]
        public void RemoveAtTest3()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1};

            var res = controller;
            res.RemoveAt(0);

            Assert.AreNotEqual(1, res.Count);
        }

        [TestMethod()]
        public void RemoveAtTest4()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            var res = controller;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => res.RemoveAt(-1));
        }

        [TestMethod()]
        public void ClearTest()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            controller.Clear();
            var res = controller.IsEmpty;

            Assert.IsTrue(res);
        }

        [TestMethod()]
        public void IndexOfTest()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            var res = controller.IndexOf(4);

            Assert.AreEqual(3, res);
        }

        [TestMethod()]
        public void IndexOfTest1()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            var res = controller.IndexOf(5);

            Assert.AreEqual(-1, res);
        }

        [TestMethod()]
        public void ContainsTest()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            var res = controller.Contains(3);

            Assert.IsTrue(res);
        }

        [TestMethod()]
        public void ContainsTest1()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            var res = controller.Contains(100);

            Assert.IsFalse(res);
        }

        [TestMethod()]
        public void CopyToTest()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            int[] res = new int[5];

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => controller.CopyTo(res, 5));
        }

        [TestMethod()]
        public void CopyToTest1()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            int[] res = new int[5];
            controller.CopyTo(res, 1);

            Assert.AreEqual(controller[0], res[1]);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            var res = controller.ToString();

            Assert.AreEqual("[ 1, 2, 3, 4 ]", res);
        }

        [TestMethod()]
        public void TthisTest()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            var res = controller;
            res[1] = 0;

            Assert.AreEqual(0, res[1]);
        }

        [TestMethod()]
        public void TthisTest1()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            var res = controller;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => res[5] = 0);
        }

        [TestMethod()]
        public void TthisTest2()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            var res = controller;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => res[1] = res[6]);
        }

        [TestMethod()]
        public void IEnumeratorTest()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            var res = "";
            foreach(int i in controller)
            {
                res += i.ToString();
            }

            Assert.AreEqual("1234", res);
        }

        [TestMethod()]
        public void IsReadOnlyTest()
        {
            DynamicArray<int> controller = new DynamicArray<int>();

            var res = controller.IsReadOnly;

            Assert.IsFalse(res);
        }

        [TestMethod()]
        public void CountTest()
        {
            DynamicArray<int> controller = new DynamicArray<int> { 1, 2, 3, 4 };

            var res = controller.Count;

            Assert.AreEqual(4, res);
        }

        [TestMethod()]
        public void DynamicArrayTest()
        {
            string[] input = { "Brachiosaurus", "Amargasaurus", "Mamenchisaurus" };
            DynamicArray<string> controller = new DynamicArray<string>(input);

            var res = controller;

            Assert.AreEqual("Brachiosaurus", res[0]);
        }

        [TestMethod()]
        public void DynamicArrayTest1()
        {
            string[] input = null;
            DynamicArray<string> controller;

            Assert.ThrowsException<ArgumentNullException>(() => controller = new DynamicArray<string>(input));
        }


    }
}