// Referencing DoublyLinkedListWithErrors
using DoublyLinkedListWithErrors;

// Reference DdlErrors
namespace TestDDL
{
        // Class for testing DDLNode
    [TestClass]
    public class DLLNodeTests
    {
            // testing constructor test 
        [TestMethod]
        public void TestConstructor()
        {
        // Create a new DLLNode object with a value of 5
        DLLNode node = new DLLNode(5);
        // Check that the value is correct
        Assert.AreEqual(5, node.num);
        // Check that the Next field is null
        Assert.IsNull(node.next);
        // Check that the Previous field is null
        Assert.IsNull(node.previous);
        }
        // testing PrimeMethod
        [TestMethod]
        public void TestIsPrime()
        {
        // Create new object,with int value 0
        // Create one node
        DLLNode node = new DLLNode(0);
        // Test cases for prime numbers - 2, 3, 5, 7, 11, 13, 17, 19, 23
        Assert.IsTrue(node.isPrime(2));
        Assert.IsTrue(node.isPrime(3));
        Assert.IsTrue(node.isPrime(5));
        Assert.IsTrue(node.isPrime(7));
        Assert.IsTrue(node.isPrime(11));
        Assert.IsTrue(node.isPrime(13));
        Assert.IsTrue(node.isPrime(17));
        Assert.IsTrue(node.isPrime(19));
        Assert.IsTrue(node.isPrime(23));
        }
        // testing if Negative
        [TestMethod]
        public void TestIsNegative()
        {
        // Create new object,with int value 0
        DLLNode node = new DLLNode(0);
        // Test cases for negative numbers -1, -2, -10
        Assert.IsFalse(node.isPrime(-1));
        Assert.IsFalse(node.isPrime(-2));
        Assert.IsFalse(node.isPrime(-10));
        }
        // testing PrimeMethod
        [TestMethod]
        public void TestIsNumber()
        {
        // Create new object,with int value 0
        DLLNode node = new DLLNode(0);
        // test cases for generic numbers - 0, 1, 2, 3, 5
        Assert.IsFalse(node.isPrime(0));
        Assert.IsFalse(node.isPrime(1));
        Assert.IsTrue(node.isPrime(2));
        Assert.IsTrue(node.isPrime(3));
        Assert.IsTrue(node.isPrime(5));
        }
        // testing NotPrimeMethod
        [TestMethod]
        public void TestIsNotPrime()
        {
        // Create new object,with int value 0
        DLLNode node = new DLLNode(0);
        // Test cases for non-prime numbers - 0, 1, 6, 15, 20
            Assert.IsFalse(node.isPrime(0));
        Assert.IsFalse(node.isPrime(1));
        Assert.IsFalse(node.isPrime(6));
        Assert.IsFalse(node.isPrime(15));
        Assert.IsFalse(node.isPrime(20));
        }
    }
}
namespace TestDDLists
{
    [TestClass]
    public class DLListTests
    {
        [TestMethod]
        public void TestNodeWithNext()
        {
        // Test node with a next node
        // Create two nodes
        DLLNode node1 = new DLLNode(1);
        DLLNode node2 = new DLLNode(2);
        // Assign node1's next reference to node2 and node2's previous reference to node1
        node1.next = node2;
        node2.previous = node1;
        // Test the values and references of the nodes
        // Check that the first node is not null
        Assert.IsNotNull(node1);
        // Check that the second node is not null
        Assert.IsNotNull(node2);
        // Check that the first node's num field is 1
        Assert.AreEqual(1, node1.num);
        // Check that the second node's num field is 2
        Assert.AreEqual(2, node2.num);
        // Check that the first node's next pointer points to the second node
        Assert.AreEqual(node2, node1.next);
        // Check that the second node's previous pointer points to the first node
        Assert.AreEqual(node1, node2.previous);
        // Check that the first node's previous pointer is null
        Assert.IsNull(node1.previous);
        // Check that the second node's next pointer is null
        Assert.IsNull(node2.next);
        }
        [TestMethod]
        public void TestNodeWithPrevious()
        {
        // Test node with a previous node
        // Create two nodes
        DLLNode node1 = new DLLNode(1);
        DLLNode node2 = new DLLNode(2);
        // Assign node2's previous reference to node1 and node1's next reference to node2
        node2.previous = node1;
        node1.next = node2;
        // Test the values and references of the nodes
        // Ensures that node1 is not null.
        Assert.IsNotNull(node1);
        // Ensures that node2 is not null.
        Assert.IsNotNull(node2);
        // Ensures that node1's field "num" is equal to 1.
        Assert.AreEqual(1, node1.num);
        //Ensures that node2's field "num" is equal to 2.
        Assert.AreEqual(2, node2.num);
        //Ensures that node2 is the next node after node1.
        Assert.AreEqual(node2, node1.next);
        // Ensures that node1 is the previous node before node2.
        Assert.AreEqual(node1, node2.previous);
        // Ensures that node1's previous node is null.
        Assert.IsNull(node1.previous);
        // Ensures that node2's next node is null.
        Assert.IsNull(node2.next);
        }
        [TestMethod]
        public void TestAddToTail()
        {
        // Test adding a node to an empty list
        // Create an empty list
        DLList list = new DLList();
        // Create a new Node
        DLLNode node = new DLLNode(1);
        // Add the node to the empty list
        list.addToTail(node);
        // Assert that the head and tail of the list are both the new node
        Assert.AreEqual(list.head, node);
        Assert.AreEqual(list.tail, node);
        // Test adding a node to a non-empty list
        // Create another node
        DLLNode node2 = new DLLNode(2);
        // Add the second node to the list
        list.addToTail(node2);
        // Assert that the head and tail of the list are the first and second node,
        Assert.AreEqual(list.head, node);
        Assert.AreEqual(list.tail, node2);
        // Assert that the next node after the first node is the second node
        Assert.AreEqual(list.head.next, node2);
        // Assert that the previous node before the second node is the first node
        Assert.AreEqual(list.tail.previous, node);
        // Test adding a null node
        // Assert that adding a null node throws a NullReferenceException
        Assert.ThrowsException<System.NullReferenceException>(() => list.addToTail(null));
        }
        [TestMethod]
        public void TestRemoveHead()
        {
        // Test removing from an empty list
        // Creating new instance 
        DLList list = new DLList();
        // Removing head from an empty list
        list.removeHead();
        // Assert that the head and tail are both null
        Assert.IsNull(list.head);
        Assert.IsNull(list.tail);
        DLLNode node = new DLLNode(1);
        // Adding a node to the head of the list
        list.addToHead(node);
        // Removing the only node in the list
        list.removeHead();
        // Assert that the head and tail are both null
        Assert.IsNull(list.head);
        Assert.IsNull(list.tail);
        // Creating Nodes
        DLLNode node2 = new DLLNode(2);
        DLLNode node3 = new DLLNode(3);
        // Adding nodes to the head of the list
        list.addToHead(node);
        list.addToHead(node2);
        list.addToHead(node3);
        // Removing the head node
        list.removeHead();
        // Assert that the new head node is node2 and that its previous node is null
        Assert.AreEqual(list.head, node2);
        Assert.AreEqual(list.head.previous, null);
        // Assert that the tail node is node1
        Assert.AreEqual(list.tail, node);
        }
        [TestMethod]
        public void TestRemoveTail()
        {
        // Test removing from an empty list
        // Create a new instance of the DLList class and call the removeTail method
        DLList list = new DLList();
        list.removeTail();
        // Assert that the head and tail of the list are both null
        Assert.IsNull(list.head);
        Assert.IsNull(list.tail);
        // Test removing from a list with one node
        // Create a new node with a value of 1 and add it to the list
        DLLNode node = new DLLNode(1);
        // Call the removeTail method and assert that the head and tail of the list are both null
        list.addToTail(node);
        list.removeTail();
        // Test removing from a list with multiple nodes
        Assert.IsNull(list.head);
        Assert.IsNull(list.tail);
        // Create two new nodes with values of 2 and 3 and add them to the list
        DLLNode node2 = new DLLNode(2);
        DLLNode node3 = new DLLNode(3);
        // Call the removeTail method and assert that the head of the list is node and the tail is node2
        list.addToTail(node);
        list.addToTail(node2);
        list.addToTail(node3);
        list.removeTail();
        // Assert that the next node after the tail is null
        Assert.AreEqual(list.head, node);
        Assert.AreEqual(list.tail, node2);
        Assert.AreEqual(list.tail.next, null);
        }
        [TestMethod]
        public void TestRemoveMiddle()
        {
        // Create a doubly linked list with five nodes: 1, 2, 3, 4, 5
        DLList list = new DLList();
        // create nodes for 1, 2, 3, 4, 5
        DLLNode node1 = new DLLNode(1);
        DLLNode node2 = new DLLNode(2);
        DLLNode node3 = new DLLNode(3);
        DLLNode node4 = new DLLNode(4);
        DLLNode node5 = new DLLNode(5);
        // Connect the Nodes
        node1.next = node2;
        node2.previous = node1;
        node2.next = node3;
        node3.previous = node2;
        node3.next = node4;
        node4.previous = node3;
        node4.next = node5;
        node5.previous = node4;
        // Remove the middle node (node with value 3)
        list.removeNode(node3);
        // Check that the list has four nodes: 1, 2, 4,  5
        Assert.AreEqual(node1.next, node2);
        Assert.AreEqual(node2.next, node4);
        Assert.AreEqual(node4.previous, node2);
        Assert.AreEqual(node4.next, node5);
        }
        [TestMethod]
        public void TestAddToEmptyList()
        {
        // Create an empty list
        DLList list = new DLList();
        // Add a node to the list
        DLLNode node1 = new DLLNode(1);
        // Add to tail
        list.addToTail(node1);
        // Check that the list has one node with value 1
        Assert.AreEqual(list.head, node1);
        Assert.AreEqual(list.tail, node1);
        Assert.AreEqual(list.head.next, null);
        Assert.AreEqual(list.head.previous, null);
        }
        [TestMethod]
        public void TestAddToHeadNotEmpty()
        {
        // Create a doubly linked list with two nodes: 1, 2
        DLList list = new DLList();
        DLLNode node1 = new DLLNode(1);
        DLLNode node2 = new DLLNode(2);
        list.head = node1;
        node1.next = node2;
        node2.previous = node1;
        list.tail = node2;
        // Add a new node with value 0 to the head of the list
        DLLNode newNode = new DLLNode(0);
        list.addToHead(newNode);
        // Check that the list has three nodes: 0, 1, 2
        Assert.AreEqual(list.head, newNode);
        Assert.AreEqual(list.tail, node2);
        Assert.AreEqual(list.head.next, node1);
        Assert.AreEqual(list.head.previous, null);
        Assert.AreEqual(list.head.next.previous, newNode);
        Assert.AreEqual(list.head.next.next, node2);
        Assert.AreEqual(list.head.next.next.previous, node1);
        }
        [TestMethod]
        public void TestAddToTailNotEmpty()
        {
        // Create a doubly linked list with one node
        DLList list = new DLList();
        DLLNode node1 = new DLLNode(1);
        list.head = node1;
        list.tail = node1;
        // Add a node to the tail of the list
        DLLNode node2 = new DLLNode(2);
        list.addToTail(node2);
        // Check that the list has two nodes: 1, 2
        Assert.AreEqual(list.head, node1);
        Assert.AreEqual(list.tail, node2);
        Assert.AreEqual(list.head.next, node2);
        Assert.AreEqual(list.tail.previous, node1);
        }
        [TestMethod]
        public void TestSearchEmptyList()
        {
        // Test searching in an empty list
        DLList list = new DLList();
        DLLNode node = list.search(1);
        Assert.IsNull(node);
        }
        [TestMethod]
        public void TestSearchNonEmptyListNotFound()
        {
        // Test searching for a node that doesn't exist in a non-empty list
        // Creating new instance
        DLList list = new DLList();
        // create three new DLLNodes
        DLLNode node1 = new DLLNode(1);
        DLLNode node2 = new DLLNode(2);
        DLLNode node3 = new DLLNode(3);
        // add the nodes to the list - 1, 2, 3
        list.addToTail(node1);
        list.addToTail(node2);
        list.addToTail(node3);
        // search for a node that doesn't exist in the list
        DLLNode node = list.search(4);
        // check if the returned node is null
        Assert.IsNull(node);
        }
        [TestMethod]
        public void TestSearchNonEmptyListFound()
        {
        // Test searching for a node that exists in a non-empty list
        // A new doubly linked list is created.
        DLList list = new DLList();
        // Three new nodes are created with values 1, 2, and 3.
        DLLNode node1 = new DLLNode(1);
        DLLNode node2 = new DLLNode(2);
        DLLNode node3 = new DLLNode(3);
        // The three nodes are added to the list in order.
        // Adding node1 to the tail of the list
        list.addToTail(node1);
        // Adding node2 to the tail of the list
        list.addToTail(node2);
        // Adding node3 to the tail of the list
        list.addToTail(node3);
        // The search method is called with a value of 2, and the returned node is assigned to node.
        DLLNode node = list.search(2);
        //  The test passes if node is equal to node2, which is the node with a value of 2
        Assert.AreEqual(node, node2);
        }
        [TestMethod]
        public void TestTotalEmptyList()
        {
        // Test total on an empty list
        // Creates a new instance of DLList()
        DLList list = new DLList();
        // The total() method is called on the empty list to get the actual total
        int expectedTotal = 0;
        int actualTotal = list.total();
        // The Assert.AreEqual() method is used to compare the expected and actual totals. If they are equal, the test passes; otherwise, it fails.
        Assert.AreEqual(expectedTotal, actualTotal);
        }
        [TestMethod]
        public void TestTotalSingleItemList()
        {
        // Test total on a list with one node
        // Creating a new instance list
        DLList list = new DLList();
        DLLNode node = new DLLNode(1);
        // Adding the created node to the tail of the list
        list.addToTail(node);
        int expectedTotal = 1;
        // Getting the total of the list
        int actualTotal = list.total();
        // Testing the total of the list
        Assert.AreEqual(expectedTotal, actualTotal);
        }
        [TestMethod]
        public void TestTotalMultipleItemList()
        {
        // Test total on a list with multiple nodes
        //Creating a new instance list
        DLList list = new DLList();
        // Creating new nodes
        DLLNode node1 = new DLLNode(1);
        DLLNode node2 = new DLLNode(2);
        DLLNode node3 = new DLLNode(3);
        // Adding node1 to the tail of the list
        list.addToTail(node1);
        //Adding node2 to the tail of the list
        list.addToTail(node2);
        //Adding node3 to the tail of the list
        list.addToTail(node3);
        // Expected total of the list
        int expectedTotal = 6;
        // Getting the total of the list
        int actualTotal = list.total();
        //Testing the total of the list
        Assert.AreEqual(expectedTotal, actualTotal);
        }
        [TestMethod]
        public void TestTotalOddNodesList()
        {
        // Test total on a list with odd number of nodes
        // Creating a new instance list 
        DLList list = new DLList();
        // Create a new node 1, 2, 3, 4, 5
        DLLNode node1 = new DLLNode(1);
        DLLNode node2 = new DLLNode(2);
        DLLNode node3 = new DLLNode(3);
        DLLNode node4 = new DLLNode(4);
        DLLNode node5 = new DLLNode(5);
        // Adding node1 to the tail of the list
        list.addToTail(node1);
        // Adding node2 to the tail of the list
        list.addToTail(node2);
        // Adding node3 to the tail of the list
        list.addToTail(node3);
        // Adding node4 to the tail of the list
        list.addToTail(node4);
        // Adding node5 to the tail of the list
        list.addToTail(node5);
        // Expected total of the list
        int expectedTotal = 15;
        // Getting the total of the list
        int actualTotal = list.total();
        // Testing the total of the list
        Assert.AreEqual(expectedTotal, actualTotal);
        }
        [TestMethod]
        public void TestTotalEvenNodesList()
        {
        // Test total on a list with even number of nodes
        // Creating new instance
        DLList list = new DLList();
        // Create a new nodes 1, 2, 3, 4
        DLLNode node1 = new DLLNode(1);
        DLLNode node2 = new DLLNode(2);
        DLLNode node3 = new DLLNode(3);
        DLLNode node4 = new DLLNode(4);
        // Adding node1 to the tail of the list
        list.addToTail(node1);
        // Adding node2 to the tail of the list
        list.addToTail(node2);
        // Adding node3 to the tail of the list
        list.addToTail(node3);
        // Adding node4 to the tail of the list
        list.addToTail(node4);
        // Expected total of the list
        int expectedTotal = 10;
        // Getting the total of the list
        int actualTotal = list.total();
        // Testing the total of the list
        Assert.AreEqual(expectedTotal, actualTotal);
        }
    }
}