namespace Problem23
/// <summary>
/// 날짜: 2024.08.21
/// 문제: 문자열 my_string이 매개변수로 주어집니다. my_string안의 모든 자연수들의 합을 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120851
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "1a2b3c4d123";
            Solution solution = new Solution();
            int ans = solution.solution(a);
            Console.WriteLine(ans);
        }

        public class Solution
        {
            public int solution(string my_string)
            {
                int answer = 0;
                char[] a = my_string.ToArray();
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] >= 48 && a[i] <= 57)
                    {
                        answer += a[i] - '0';
                    }
                }
                return answer;
            }
        }
    }
}
