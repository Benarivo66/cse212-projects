using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    
    // Defect(s) Found: No defect found, test passed
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Arsenal", 19);
        priorityQueue.Enqueue("Liverpool", 20);
        priorityQueue.Enqueue("Nottingham Forest", 18);
        priorityQueue.Enqueue("Manchester United", 6);

        Assert.AreEqual("Liverpool", priorityQueue.Dequeue());
        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Defect(s) Found: It does not remove the item with the highest priority because it loops from index 0 to the end passing the highest index to a later item
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Arsenal", 4);
        priorityQueue.Enqueue("Inter Milan", 10);
        priorityQueue.Enqueue("PSG", 10);
        priorityQueue.Enqueue("Barcelona", 6);

        Assert.AreEqual("Inter Milan", priorityQueue.Dequeue());
        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
// Defect(s) Found: No defect found
public void TestPriorityQueue_Empty()
{
    var priorityQueue = new PriorityQueue();

    Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
}

[TestMethod]
// Defect(s) Found: Dequeue doesn't remove items — same item returned twice.
public void TestPriorityQueue_MultipleDequeue()
{
    var priorityQueue = new PriorityQueue();
    priorityQueue.Enqueue("X", 2);
    priorityQueue.Enqueue("Y", 4);
    priorityQueue.Enqueue("Z", 3);

    var first = priorityQueue.Dequeue(); 
    var second = priorityQueue.Dequeue(); 

    Assert.AreEqual("Y", first);
    Assert.AreEqual("Z", second);
}

}