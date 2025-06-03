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

