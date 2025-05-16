using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and verify Dequeue returns the highest priority item.
    // Expected Result: Dequeue returns items in order of highest priority.
    // Defect(s) Found: None after fixes.
    public void TestPriorityQueue_1()
    {
        // PriorityQueue is a unique class that prioritizes the "highest" item
        var priorityQueue = new PriorityQueue();
        // PriorityQueue reads the num not the string
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 3);
        priorityQueue.Enqueue("Medium", 2);

        // Assert.AreEqual is used to verify that the actual result matches the expected result
        // Assert.AreEqual("expected result", actual result)
        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue items with the same priority and verify FIFO order.
    // Expected Result: Dequeue returns items in the order they were enqueued if priorities are equal.
    // Defect(s) Found: None after fixes.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        // nums are the same, so it follows FIFO (first in first out order)
        priorityQueue.Enqueue("First", 1);
        priorityQueue.Enqueue("Second", 1);
        priorityQueue.Enqueue("Third", 1);

        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }


    // Add more test cases as needed below.
}