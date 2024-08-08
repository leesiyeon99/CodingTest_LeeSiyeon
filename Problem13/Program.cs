namespace Problem13
/// <summary>
/// 날짜: 2024.08.08
/// 문제: 정수가 들어 있는 배열 num_list가 매개변수로 주어집니다. num_list의 원소의 순서를 거꾸로 
/// 뒤집은 배열을 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120821
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] num = { 1, 2, 3, 4, 5, 6 };
            int[] answer = solution.solution(num);
            foreach (int i in answer)
            {
                Console.Write(" "+ i + " ");
            }
        }

        public class Solution
        {
            public int[] solution(int[] num_list)
            {
                int[] answer = new int[num_list.Length];
                answer = num_list.Reverse().ToArray();
                return answer;
            }
        }
    }
}
