namespace Problem9
/// <summary>
/// 날짜: 2024.08.06
/// 문제: 정수 n이 매개변수로 주어질 때, n 이하의 홀수가 오름차순으로 담긴 배열을 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120813
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] answer = solution.solution(15);
            foreach (int i in answer)
            {
                Console.Write($" {i} ");
            }
        }

        public class Solution
        {
            public int[] solution(int n)
            {
                List<int> list = new List<int>();
                List<int> result = new List<int>();
                for (int i = 1; i <= n; i++)
                {
                    result.Add(i);
                }

                for (int i = 0; i < n; i++)
                {
                    if (result[i] % 2 != 0)
                    {
                        list.Add(result[i]);
                    }
                }
                return list.ToArray();
            }

            public int[] OtherSolution1(int n)
            {
                List<int> answer = new List<int>();

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 1)
                        answer.Add(i);
                }

                return answer.ToArray();
            }
        }
    }
}
