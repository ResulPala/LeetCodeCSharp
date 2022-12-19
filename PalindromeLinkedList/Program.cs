using PalindromeLinkedList;

public class Program
{
    private static void Main(string[] args)
    {
        int[] valuesLinkedList = new int[] { 1, 2, 2, 1, };

        MyLinkedList myLinkedList = new MyLinkedList();

        Node head = new Node();
        

        foreach (int value in valuesLinkedList)
        {         
            myLinkedList.AddNode(head, value);
        }

        myLinkedList.Print(head); // 0 1 2 2 1

        SolutionOne solutionOne = new SolutionOne();

        var result = solutionOne.IsPalindrome(head);
        Console.WriteLine(result);

    }
}

public class SolutionOne
{
    List<int> tempList = new List<int>();

    public bool IsPalindrome(Node head)
    {
        tempList.Add(head.data);
        Node current = head;

        while(current.next != null)
        {
            tempList.Add(current.next.data);
            current = current.next;
        }

        for(int i = 0; i < tempList.Count/2; i++)
        {
            if(tempList[i] != tempList[tempList.Count - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}