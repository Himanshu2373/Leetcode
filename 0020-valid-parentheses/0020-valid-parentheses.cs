public class Solution {
    public bool IsValid(string s) {
        //  HashSet<char> cl = new HashSet<char> { '(', '{', '[' };
        //  Dictionary<char , char> mp = new Dictionary<char , char> {
        //     { ')', '(' },
        //     { '}', '{' },
        //     { ']', '[' }
        // };
        //  Stack<char> stack = new Stack<char>();
        //  foreach(char i in s.ToCharArray()){
        //         if ( cl.Contains(i)){
        //             stack.Push(i);
        //         }
        //         else if (mp.ContainsKey(i) && stack.Count>0)
        //         {
        //             if (stack.Peek()==mp[i]){
        //                 stack.Pop();
        //             }
        //         else
        //         {
        //                 return false;
        //         }
                    
        //     }
        //  }
        //  return stack.Count==0;

        var stack = new Stack<char>();
        var matchingBrackets = new Dictionary<char, char> {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

        foreach (char ch in s) {
            if (matchingBrackets.ContainsValue(ch)) {
                stack.Push(ch);
            } else if (matchingBrackets.ContainsKey(ch)) {
                if (stack.Count == 0 || stack.Pop() != matchingBrackets[ch]) {
                    return false;
                }
            }
        }

        return stack.Count == 0;

    }
}