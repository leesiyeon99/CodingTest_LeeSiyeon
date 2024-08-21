namespace Problem26
/// <summary>
/// 날짜: 2024.08.22
/// 문제: 정수 n과 정수 배열 numlist가 매개변수로 주어질 때, 
/// numlist에서 n의 배수가 아닌 수들을 제거한 배열을 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120905
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Solution solution = new Solution();
            int[] ans = solution.solution(3, list);
            foreach (int i in ans)
            {
                Console.WriteLine(i);
            }
        }

        public class Solution
        {
            public int[] solution(int n, int[] numlist)
            {

                int count = 0;
                int numbers = 0;
                foreach (int j in numlist)
                {
                    if (j % n == 0)
                    {
                        numbers++;
                    }
                }
                int[] answer = new int[numbers];
                foreach (int i in numlist)
                {
                    if (i % n == 0)
                    {
                        answer[count] = i;
                        count++;
                    }

                }

                return answer;
            }
        }
    }
}
