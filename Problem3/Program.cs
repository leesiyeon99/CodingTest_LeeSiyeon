using System.Text.RegularExpressions;

namespace Problem3
/// <summary>
/// 날짜: 2024.08.12
/// 문제: 문자열 my_string이 매개변수로 주어질 때, my_string 안에 있는 숫자만 골라 오름차순 정렬한 리스트를
/// return 하도록 solution 함수를 작성해보세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120850
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] a = solution.MySolution2("헬로우121430");
            Console.WriteLine(string.Join(",", a));
        }

        public class Solution
        {
            public int[] MySolution2(string my_string)
            {
                List<int> list = new List<int>();
                List<char> input = new List<char>(my_string);
                for (int i = 0; i < input.Count; i++)
                {
                    if (char.IsDigit(input[i]))
                    {
                        list.Add(input[i] - '0');
                    }
                    list.Sort();
                }

                return list.ToArray();
            }
            public int[] MySolution(string my_string)
            {
                List<int> input = new List<int>();
                my_string.ToArray();

                for (int i = 0; i < my_string.Length; i++)
                {
                    char c = my_string[i];
                    if(char.IsDigit(c)) //IsDight 숫자인지 문자인지 확인, 반환형은 bool
                    {
                        input.Add(c-'0');
                    }
                    input.Sort();
                    
                }
                return input.ToArray();
            }

            public int[] OtherSolution(string my_string)
            {
                string s = Regex.Replace(my_string, @"\D", "");  // \D: 숫자가 아닌 모든 문자 , my_string에서 숫자가 아닌 모든 문자는 ""로 만들어서 숫자만 포함된 문자열 만듦
                int[] answer = new int[s.Length];

                for (int i = 0; i < s.Length; i++)
                {
                    answer[i] = int.Parse(s[i].ToString());
                }

                Array.Sort(answer);

                return answer;
            }
        }

    }
}
