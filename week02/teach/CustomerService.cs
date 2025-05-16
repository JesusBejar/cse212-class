/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.  
/// 
///1. The user shall specify the maximum size of the Customer Service Queue when it is created. 
/// If the size is invalid (less than or equal to 0) then the size shall default to 10.
// 2. The AddNewCustomer method shall enqueue a new customer into the queue.
// 3. If the queue is full when trying to add a customer, then an error message will be displayed.
// 4. The ServeCustomer function shall dequeue the next customer from the queue and display the details.
// 5. If the queue is empty when trying to serve a customer, then an error message will be displayed.
/// </summary>
public class CustomerService {

    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases

        // Test 1
        // Scenario: get the size of the queue from user
        // Expected Result: assert the size of the queue is input or default to 10 if any answer <= 0
        Console.WriteLine("Test 1");
        Console.WriteLine("What is the max size of the queue?");
        var maxSize = int.Parse(Console.ReadLine()!);
        // queue declaration right here
        var customerServiceQueue = new CustomerService(maxSize);
        // Assert.AreEqual(maxSize, customerServiceQueue._maxSize);
        if (maxSize <= 0) {
            if (customerServiceQueue._maxSize != 10) {
                Console.WriteLine($"error: maxSize was {maxSize}, but queue._maxSize is {customerServiceQueue._maxSize}");
            }
        } else {
            if (customerServiceQueue._maxSize != maxSize) {
                Console.WriteLine($"error: maxSize was {maxSize}, but queue._maxSize is {customerServiceQueue._maxSize}");
            }
        }
        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Test 2
        // Scenario: use AddNewCustomer to add a customer to the queue
        // Expected Result: assert the customer is added to the queue
        Console.WriteLine("Test 2");

        // Defect(s) Found: 

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count > _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        _queue.RemoveAt(0);
        var customer = _queue[0];
        Console.WriteLine(customer);
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + string.Join(", ", _queue) + "]";
    }
}