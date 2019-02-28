using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challanges_Leetcode
{
    /// <summary>
    /// 3. Longest Substring Without Repeating Characters
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    class Solution1
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            else if (s.Length == 1)
            {
                return 1;
            }
            else // 2....n
            {
                int iBegin = 0;
                int iEnd = 0;
                int longest = 1;
                int currLength;

                for (int iCurrent = 1; iCurrent < s.Length; iCurrent++)
                {
                    bool isDuplicate = false;

                    // check if char is not a duplicate for the current longest substr
                    for (int iFinder = iCurrent - 1; iFinder >= iBegin && !isDuplicate; iFinder--)
                    {
                        if (s[iFinder] == s[iCurrent])  //if duplicate
                        {
                            // update the longest
                            currLength = iEnd - iBegin + 1;
                            if (currLength > longest)
                            {
                                longest = currLength;
                            }

                            // update the begin char to exclude the previous occurence
                            iBegin = iFinder + 1;
                            
                            isDuplicate = true; // break
                        }
                    }
                    // append the last one to the current substr
                    iEnd = iCurrent;
                }

                // update the longest for the last part
                currLength = iEnd - iBegin + 1;
                if (currLength > longest)
                {
                    longest = currLength;
                }

                return longest;
            }
        }
    }
}
