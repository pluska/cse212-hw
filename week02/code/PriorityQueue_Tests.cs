using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: Throws InvalidOperationException.
    public void TestDequeue_EmptyQueue_ThrowsException()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue and Dequeue with one item.
    // Expected Result: Returns the single item.
    public void TestDequeue_SingleItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Manuel", 1);
        Assert.AreEqual("Manuel", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items and Dequeue highest priority.
    // Expected Result: Returns the item with the highest priority.
    public void TestDequeue_HighestPriorityItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Manuel", 1);
        priorityQueue.Enqueue("Sofia", 3);
        priorityQueue.Enqueue("Eduardo", 2);
        Assert.AreEqual("Sofia", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with the same priority.
    // Expected Result: Returns the first item with the highest priority.
    public void TestDequeue_SamePriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Manuel", 3);
        priorityQueue.Enqueue("Sofia", 3);
        priorityQueue.Enqueue("Eduardo", 2);
        Assert.AreEqual("Manuel", priorityQueue.Dequeue());
    }
}
