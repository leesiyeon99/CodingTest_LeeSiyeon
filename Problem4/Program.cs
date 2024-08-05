namespace Problem4
{
    /// <summary>
    /// 날짜: 2024.08.12
    /// 문제: 정수가 담긴 리스트 num_list가 주어질 때, num_list의 원소 중 짝수와 홀수의 개수를 담은 배열을 return 하도록 solution 함수를 완성해보세요.
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120824
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] input = { 1, 2, 3, 4, 5 };
            int[] answer = solution.solution(input);

            foreach (int i in answer)
            {
                Console.Write($"{i} ");
            }
        }

        public class Solution
        {
            public int[] solution(int[] num_list)
            {
                int[] answer = new int[2];
                int[] list = num_list;
                int oddcount = 0;
                int evenCount = 0;
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        evenCount++;
                    }
                    else if (list[i] % 2 != 0)
                    {
                        oddcount++;
                    }
                }
                answer[0] = evenCount;
                answer[1] = oddcount;
                return answer;
            }

        }
    }
}
