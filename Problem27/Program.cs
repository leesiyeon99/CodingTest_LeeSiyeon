namespace Problem27
/// <summary>
/// 날짜: 2024.08.23
/// 문제: 어떤 자연수를 제곱했을 때 나오는 정수를 제곱수라고 합니다. 정수 n이 매개변수로 주어질 때, 
/// n이 제곱수라면 1을 아니라면 2를 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120909
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int num = solution.solution(976);
            Console.WriteLine(num);
        }

        public class Solution
        {
            public int solution(int n)
            {
                int answer = 0;
                int num = 0;
                double a = Math.Sqrt(n);
                if (Math.Sqrt(n) == (int)a)
                {
                    answer = 1;
                }
                else
                    answer = 2;
                return answer;
            }
        }
    }
}
