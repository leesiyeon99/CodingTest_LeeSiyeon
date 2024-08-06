namespace Problem8
/// <summary>
/// 날짜: 2024.08.06
/// 문제: 중앙값은 어떤 주어진 값들을 크기의 순서대로 정렬했을 때 가장 중앙에 위치하는 값을 의미합니다. 
/// 예를 들어 1, 2, 7, 10, 11의 중앙값은 7입니다. 정수 배열 array가 매개변수로 주어질 때, 
/// 중앙값을 return 하도록 solution 함수를 완성해보세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120811
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] input = { 9, -1, 0 };
            int answer = solution.solution(input);
            Console.WriteLine(answer);
        }

        public class Solution
        {
            public int solution(int[] array)
            {
                int answer = 0;
                Array.Sort(array);
                int length = (array.Length - 1) / 2;
                answer = array[length];

                return answer;
            }
        }
    }
}
