namespace Problem7
/// <summary>
/// 날짜: 2024.08.05
/// 문제: 정수 배열 numbers가 매개변수로 주어집니다. numbers의 각 원소에 두배한 원소를 가진 배열을 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120809
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] numbers = { 1, 3, 4, -5, 6, 7};
            int[] ints = solution.solution(numbers);
            foreach (int i in ints)
            {
                Console.Write($" {i} ");
            }
        }

        public class Solution
        {
            public int[] solution(int[] numbers)
            {
                int[] answer = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    answer[i] = numbers[i] * 2;
                }
                return answer;
            }
        }
    }
}
