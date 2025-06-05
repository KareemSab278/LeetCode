// i want problems. ALWAYS

//=================================== 1 ===================================

// public class Solution {
//     public int[] TwoSum(int[] nums, int target) {
//         int[] sorted = (int[])nums.Clone();
//         Array.Sort(sorted);

//         int left = 0;
//         int right = sorted.Length - 1;
//         int num1 = 0, num2 = 0;

//         while (left < right) {
//             int sum = sorted[left] + sorted[right];
//             if (sum == target) {
//                 num1 = sorted[left];
//                 num2 = sorted[right];
//                 break;
//             } else if (sum < target) {
//                 left++;
//             } else {
//                 right--;
//             }
//         }

//         int[] result = new int[2];
//         int found = 0;
//         for (int i = 0; i < nums.Length && found < 2; i++) {
//             if (nums[i] == num1 || nums[i] == num2) {
//                 result[found++] = i;
//             }
//         }

//         return result;
//     }
// }

//=================================== 2 ===================================

// public class Solution
// {
//     public bool IsPalindrome(int x)
//     {
//         string original = x.ToString();
//         string reversed = new string(original.Reverse().ToArray());
//         return original == reversed;
//     }
// }

//=================================== 3 ===================================

// public class Solution {
//     public int RomanToInt(string s) {
//         Dictionary<string, int> romanMap = new Dictionary<string, int>{
//             {"IV", 4}, {"IX", 9}, {"XL", 40}, {"XC", 90}, {"CD", 400}, {"CM", 900},
//             {"I", 1}, {"V", 5}, {"X", 10}, {"L", 50}, {"C", 100}, {"D", 500}, {"M", 1000}
//         };

//         int total = 0;
//         int i = 0;

//         while (i < s.Length) {
//             if (i + 1 < s.Length) {
//                 string twoChar = s.Substring(i, 2);
//                 if (romanMap.ContainsKey(twoChar)) {
//                     total += romanMap[twoChar];
//                     i += 2;
//                     continue;
//                 }
//             }

//             string oneChar = s.Substring(i, 1);
//             total += romanMap[oneChar];
//             i++;
//         }

//         return total;
//     }
// }

//=================================== 4 ===================================

// using System.Linq;

// public class Solution {
//     public string LongestCommonPrefix(string[] strs) {
//         if (strs == null || strs.Length == 0) return "";

//         Array.Sort(strs, (a, b) => a.Length.CompareTo(b.Length));
//         string firstWord = strs[0];
//         string output = "";

//         for (int i = 0; i < firstWord.Length; i++) {
//             output += firstWord[i];
//             if (!strs.All(s => s.StartsWith(output))) {
//                 return output.Substring(0, output.Length - 1);
//             }
//         }
//         return output;
//     }
// }

//=================================== 5 ===================================

public class Solution
{
    public bool IsValid(string s)
    {
        char[] sArr = s.ToCharArray();
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < sArr.Length; i++)
        {
            switch (sArr[i])
            {
                case '(': stack.Push(')'); break;
                case '{': stack.Push('}'); break;
                case '[': stack.Push(']'); break;
                case ')':
                case '}':
                case ']':
                    if (stack.Count == 0 || stack.Pop() != sArr[i])
                        return false;
                    break;

                default:
                    return false;
            }
        }

        return stack.Count == 0;
    }
}


//=================================== 6 ===================================
