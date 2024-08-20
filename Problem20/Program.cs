namespace Problem20
/// <summary>
/// 날짜: 2024.08.21
/// 문제: 두 배열이 얼마나 유사한지 확인해보려고 합니다. 문자열 배열 s1과 s2가 주어질 때 
/// 같은 원소의 개수를 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120903
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] a = { "a", "b", "c" };
            string[] b = { "com", "b", "d", "p", "c" };
            int ans = solution.solution(a,b);
            Console.WriteLine(ans);
        }

        public class Solution
        {
            public int solution(string[] s1, string[] s2)
            {
                int answer = 0;
                for (int i = 0; i < s1.Length; i++)
                {
                    for (int j = 0; j < s2.Length; j++)
                    {
                        if (s1[i] == s2[j])
                            answer++;
                    }
                }
                return answer;
            }
        }
    }
}
