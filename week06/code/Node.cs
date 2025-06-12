public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // if value == Data, ignore it's a duplicate
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        
        // base case, value found 
        if (value == Data)
            return true;
        
        // search left subtree
        if (value < Data)
        {
            // short circuit this bad puppy
            // null check and callback
            return Left != null && Left.Contains(value);
        }
        
        // search right subtree
        if (value > Data)
        {
            return Right != null && Right.Contains(value);
        }
        
        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        return 0; // Replace this line with the correct return statement(s)
    }
}