namespace Problem14
/// <summary>
/// 날짜: 2024.08.08
/// 문제: 정수 배열 numbers가 매개변수로 주어집니다. numbers의 원소 중 두 개를 곱해 만들 수 있는 
/// 최댓값을 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120847
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] num = { 1, 2, 3, 4, 5, 6 };
            int answer = solution.solution(num);
            Console.WriteLine(answer);
        }

        public class Solution
        {
            public int solution(int[] numbers)
            {
                int answer = 0;
                Array.Sort(numbers);
                answer = numbers[numbers.Length-1] * numbers[numbers.Length-2];
                return answer;
            }
        }
    }
}
