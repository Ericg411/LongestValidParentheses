namespace LongestValidParenthesesRepo;
public class Class1
{

    public int largest = 0;

    public int LongestValidParentheses(string s)
    {
        if (s == "")
        {
            return 0;
        }
        isValid(s, 0);
        return largest;
    }

    public bool isValid(string s, int index)
    {
        int counter = 0;
        for (int i = index; i < s.Length; i++)
        {
            if (counter == 0 && s[i] == ')')
            {
                if (i > largest)
                {
                    largest = i;
                }
                isValid(s.Substring(1), 0);
                return false;
            }
            else if (counter == 0 && i > 0 && s[i] == '(')
            {
                if (i > largest)
                {
                    largest = i;
                }
            }
            switch (s[i])
            {
                case '(':
                    counter++;
                    break;
                case ')':
                    counter--;
                    break;
                default:
                    break;
            }
        }
        if (counter == 0)
        {
            if (s.Length > largest)
            {
                largest = s.Length;
            }
            return true;
        }
        else
        {
            index++;
            isValid(s.Substring(index), 0);
            return false;
        }

    }
}
