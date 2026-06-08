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

       // Ignore duplicates
    if (value == Data)
    {
        return;
    }

    if (value < Data)
    {
        if (Left is null)
            Left = new Node(value);
        else
            Left.Insert(value);
    }
    else
    {
        if (Right is null)
            Right = new Node(value);
        else
            Right.Insert(value);
    }
}


// TODO Start Problem 2
  public bool Contains(int value)
{
    // Found it
    if (value == Data)
    {
        return true;
    }

    // Search left
    if (value < Data)
    {
        if (Left is null)
            return false;

        return Left.Contains(value);
    }

    // Search right
    if (Right is null)
        return false;

    return Right.Contains(value);
}

// TODO Start Problem 4
  public int GetHeight()
{
    int leftHeight = Left?.GetHeight() ?? 0;
    int rightHeight = Right?.GetHeight() ?? 0;

    return 1 + Math.Max(leftHeight, rightHeight);
}

}