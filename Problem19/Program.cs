﻿namespace Problem19
/// <summary>
/// 날짜: 2024.08.18
/// 문제: 정수 배열 numbers와 정수 num1, num2가 매개변수로 주어질 때, 
/// numbers의 num1번 째 인덱스부터 num2번째 인덱스까지 자른 정수 배열을 
/// return 하도록 solution 함수를 완성해보세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120833
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] num = { 1, 2, 3, 4, 5 };
            int[] ans = solution.solution(num, 1, 3);
            foreach (int i in ans)
            {
                Console.WriteLine(i);
            }
        }

        public class Solution
        {
            public int[] solution(int[] numbers, int num1, int num2)
            {
                int[] answer = new int[num2-num1+1];
                int x = 0;
                for (int i = num1; i <= num2; i++)
                {
                    answer[x] = numbers[i];
                    x++;
                }

                return answer;
            }
        }
    }
}
