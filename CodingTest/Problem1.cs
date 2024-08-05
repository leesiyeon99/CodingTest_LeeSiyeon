namespace CodingTest
{
    /// <summary>
    /// 날짜: 2024.08.12
    /// 문제: 문자열 my_string이 매개변수로 주어집니다. my_string을 거꾸로 뒤집은 문자열을 return하도록 solution 함수를 완성해주세요.
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120822
    /// </summary>
    internal class Problem1
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.solution("Leesiyeon");
        }

        public class Solution
        {
            public string solution(string my_string)
            {
                string answer = my_string;
                string c="";
                List<char> ans = new List<char> (answer.Substring(0, answer.Length));
                ans.Reverse();
                for (int i = 0; i < ans.Count; i++)
                {
                    c += ans[i];
                }
                answer = c;
                Console.WriteLine (answer);

                return answer;
            }
        }
    }
}
