using System.Collections.Generic;

namespace Backtracking
{
    public class LetterCombinationsPhoneNumbers
    {
        /// <summary>
        /// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public IList<string> LetterCombinations(string digits)
        {
            string[] dict = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            IList<string> res = new List<string>();
            BackTracking_LetterCombinations(res,digits, "" ,dict);
            return res;
        }

        private void BackTracking_LetterCombinations(IList<string> res, string combination, string digits, string[] dict)
        {
            if (combination.Length == digits.Length) {
                res.Add(new string(combination));
                return;
            }
            else{
                for (int i = 0; i < digits.Length; i++)
                {
                    var letter = DigitToLetters(digits[i]);
                    foreach (var item in letter.ToCharArray())
                    {
                        BackTracking_LetterCombinations(res, combination + item, digits, dict);
                    }
                }
            }
        }
        private string DigitToLetters(char digit)
        {
            Dictionary<char, string> digitMap = new Dictionary<char, string>();
            digitMap.Add('2',"abc");
            digitMap.Add('3', "def");
            digitMap.Add('4', "ghi");
            digitMap.Add('5', "jkl");
            digitMap.Add('6', "mno");
            digitMap.Add('7', "pqrs");
            digitMap.Add('8', "uvw");
            digitMap.Add('9', "xyz");
            if (digitMap.ContainsKey(digit))
            {
                return digitMap[digit];
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
