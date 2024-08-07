namespace Problem11
/// <summary>
/// 날짜: 2024.08.07
/// 문제: 문자열 my_string과 정수 n이 매개변수로 주어질 때, my_string에 들어있는 각 문자를 
/// n만큼 반복한 문자열을 return 하도록 solution 함수를 완성해보세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120825
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string answer = solution.solution("hello", 3);
            Console.WriteLine(answer);
        }

        public class Solution
        {
            public string solution(string my_string, int n)
            {
                string answer = "";
                for (int i = 0; i < my_string.Length; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        answer += my_string[i];
                    }
                }

                return answer;
            }

            public class OtherSolution
            {
                public string solution(string my_string, int n)
                {
                    string answer = "";

                    foreach (var c in my_string)
                    {
                        answer += new string(c, n); 
                    }

                    return answer;
                }
            }
        }
    }
}
