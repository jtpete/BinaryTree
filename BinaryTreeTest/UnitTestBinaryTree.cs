using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryTree;

namespace BinaryTreeTest
{
    [TestClass]
    public class UnitTestBinaryTree
    {
        //Test Constructor
        [TestMethod]
        public void ConstructorRoot()
        {
            BinaryTree<int> intTree = new BinaryTree<int>();

            Assert.IsNull(intTree.Root);
        }
        [TestMethod]
        public void ConstructorCount()
        {
            int size = 0;
            BinaryTree<int> intTree = new BinaryTree<int>();

            Assert.AreEqual(size, intTree.Count);
        }


        //Test Add
        [TestMethod]
        public void AddSingleInt()
        {
            BinaryTree<int> intTree = new BinaryTree<int>();
            int item = 54; 

            intTree.Add(item);

            Assert.IsNotNull(intTree.Root);
            Assert.AreEqual(1, intTree.Count);
        }
        [TestMethod]
        public void AddSingleString()
        {
            BinaryTree<string> stringTree = new BinaryTree<string>();
            string item = "Jason";

            stringTree.Add(item);

            Assert.IsNotNull(stringTree.Root);
            Assert.AreEqual(1, stringTree.Count);
        }
        [TestMethod]
        public void AddSingleObject()
        {
            BinaryTree<Person> objTree = new BinaryTree<Person>();
            Person item = new Person("Jason", 40, "Brown");

            objTree.Add(item);

            Assert.IsNotNull(objTree.Root);
            Assert.AreEqual(1, objTree.Count);
        }
        [TestMethod]
        public void AddMultipleInt()
        {
            BinaryTree<int> intTree = new BinaryTree<int>();
            int[] item = { 54, 175, 49, 25, -12, 85, -123, 68, 490, 3000, -1290, 0, 65 };

            for(int i = 0; i<item.Length; i++)
                intTree.Add(item[i]);

            Assert.IsNotNull(intTree.Root);
            Assert.AreEqual(item.Length, intTree.Count);
        }
        [TestMethod]
        public void AddMultipleString()
        {
            BinaryTree<string> stringTree = new BinaryTree<string>();
            string[] names = new string[] { "Jason", "Bob", "Michelle", "Lucas", "Frank", "Mike", "Jose", "Patricia" };

            for (int i = 0; i < names.Length; i++)
                stringTree.Add(names[i]);

            Assert.IsNotNull(stringTree.Root);
            Assert.AreEqual(names.Length, stringTree.Count);
        }
        [TestMethod]
        public void AddMultipleObjects()
        {
            BinaryTree<string> objTree = new BinaryTree<string>();
            Person person1 = new Person("Jason", 40, "Black");
            Person person2 = new Person("Michelle", 39, "Blond");
            Person person3 = new Person("Lucas", 12, "Brown");
            Person person4 = new Person("Carter", 10, "Black");
            Person person5 = new Person("Brook", 7, "Blond");
            Person person6 = new Person("Pat", 80, "Purple");
            Person person7 = new Person("Frank", 39, "Blond");
            Person person8 = new Person("Jonathan", 21, "Brown");
            Person person9 = new Person("Bob", 10, "Black");
            Person person10 = new Person("Darcy", 70, "Blond");
            Person[] people = new Person[] { person1, person2, person3, person4, person5, person6, person7, person8, person9, person10 };

            for (int i = 0; i < people.Length; i++)
                objTree.Add(people[i]);

            Assert.IsNotNull(objTree.Root);
            Assert.AreEqual(people.Length, objTree.Count);

        }
        [TestMethod]
        public void StressTestInt()
        {
            BinaryTree<int> intTree = new BinaryTree<int>();
            Random rand = new Random();
            int[] item = new int[1000];
            for (int i = 0; i < item.Length; i++)
                item[i] = rand.Next(-1000, 1000);

            for (int i = 0; i < item.Length; i++)
                intTree.Add(item[i]);

            Assert.IsNotNull(intTree.Root);
            Assert.AreEqual(item.Length, intTree.Count);
        }

        //Test Find
        [TestMethod]
        public void FindInt()
        {
            BinaryTree<int> intTree = new BinaryTree<int>();
            int[] item = { 54, 175, 49, 25, -12, 85, -123, 68, 490, 3000, -1290, 0, 65 };
            int lookFor = 85;

            for (int i = 0; i < item.Length; i++)
                intTree.Add(item[i]);

            Assert.IsTrue(intTree.Contains(lookFor));
        }
        [TestMethod]
        public void FindString()
        {
            BinaryTree<string> stringTree = new BinaryTree<string>();
            string[] names = new string[] { "Jason", "Bob", "Michelle", "Lucas", "Frank", "Mike", "Jose", "Patricia" };
            string lookFor = "Frank";

            for (int i = 0; i < names.Length; i++)
                stringTree.Add(names[i]);

            Assert.IsTrue(stringTree.Contains(lookFor));
        }
        [TestMethod]
        public void FindObject()
        {
            BinaryTree<Person> objTree = new BinaryTree<Person>();
            Person person1 = new Person("Jason", 40, "Black");
            Person person2 = new Person("Michelle", 39, "Blond");
            Person person3 = new Person("Lucas", 12, "Brown");
            Person person4 = new Person("Carter", 10, "Black");
            Person person5 = new Person("Brook", 7, "Blond");
            Person person6 = new Person("Pat", 80, "Purple");
            Person person7 = new Person("Frank", 39, "Blond");
            Person person8 = new Person("Jonathan", 21, "Brown");
            Person person9 = new Person("Bob", 10, "Black");
            Person person10 = new Person("Darcy", 70, "Blond");
            Person[] people = new Person[] { person1, person2, person3, person4, person5, person6, person7, person8, person9, person10 };
            Person lookFor = person8;

            for (int i = 0; i < people.Length; i++)
                objTree.Add(people[i]);

            Assert.IsTrue(objTree.Contains(lookFor));
        }
        [TestMethod]
        public void DontFindInt()
        {
            BinaryTree<int> intTree = new BinaryTree<int>();
            int[] item = { 54, 175, 49, 25, -12, 85, -123, 68, 490, 3000, -1290, 0, 65 };
            int lookFor = 44;

            for (int i = 0; i < item.Length; i++)
                intTree.Add(item[i]);

            Assert.IsFalse(intTree.Contains(lookFor));
        }
        [TestMethod]
        public void DontFindString()
        {
            BinaryTree<string> stringTree = new BinaryTree<string>();
            string[] names = new string[] { "Jason", "Bob", "Michelle", "Lucas", "Frank", "Mike", "Jose", "Patricia" };
            string lookFor = "Adam";

            for (int i = 0; i < names.Length; i++)
                stringTree.Add(names[i]);

            Assert.IsFalse(stringTree.Contains(lookFor));
        }
        [TestMethod]
        public void DontFindObject()
        {
            BinaryTree<Person> objTree = new BinaryTree<Person>();
            Person person1 = new Person("Jason", 40, "Black");
            Person person2 = new Person("Michelle", 39, "Blond");
            Person person3 = new Person("Lucas", 12, "Brown");
            Person person4 = new Person("Carter", 10, "Black");
            Person person5 = new Person("Brook", 7, "Blond");
            Person person6 = new Person("Pat", 80, "Purple");
            Person person7 = new Person("Frank", 39, "Blond");
            Person person8 = new Person("Jonathan", 21, "Brown");
            Person person9 = new Person("Bob", 10, "Black");
            Person person10 = new Person("Darcy", 70, "Blond");
            Person person11 = new Person("Mike", 100, "Grey");
            Person[] people = new Person[] { person1, person2, person3, person4, person5, person6, person7, person8, person9, person10 };
            Person lookFor = person11;

            for (int i = 0; i < people.Length; i++)
                objTree.Add(people[i]);

            Assert.IsFalse(objTree.Contains(lookFor));
        }
    }
}
