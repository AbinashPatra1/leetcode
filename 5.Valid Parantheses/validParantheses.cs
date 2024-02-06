//using System.Collections;

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        char[] chars = s.ToCharArray();
        foreach (char c in chars)
        {
            char topC = new char();
            if (stack.Count > 0)
            {
                topC = stack.Peek();
            }

            if (c == ')' && topC == '(')
            {
                stack.Pop();
            }
            else if (c == '}' && topC == '{')
            {
                stack.Pop();
            }
            else if (c == ']' && topC == '[')
            {
                stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }
        if (stack.Count == 0)
            return true;
        else
            return false;

    }
}