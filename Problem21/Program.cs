﻿namespace Problem21
/// <summary>
/// 날짜: 2024.08.21
/// 문제: x 좌표 (x, y)를 차례대로 담은 정수 배열 dot이 매개변수로 주어집니다. 
/// 좌표 dot이 사분면 중 어디에 속하는지 1, 2, 3, 4 중 하나를 return 하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120841
/// </summary>

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public int solution(int[] dot)
        {
            int answer = 0;
            if (dot[0] > 0 && dot[1] > 0)
            {
                answer = 1;
            }
            if (dot[0] < 0 && dot[1] > 0)
            {
                answer = 2;
            }
            if (dot[0] > 0 && dot[1] < 0)
            {
                answer = 4;
            }
            if (dot[0] < 0 && dot[1] < 0)
            {
                answer = 3;
            }
            return answer;
        }
    }
}
