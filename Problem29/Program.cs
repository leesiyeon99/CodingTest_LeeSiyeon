namespace Problem29
/// <summary>
/// 날짜: 2024.08.26
/// 문제: 정수가 담긴 리스트 num_list가 주어질 때, 
/// 리스트의 길이가 11 이상이면 리스트에 있는 모든 원소의 합을 10 이하이면 모든 원소의 곱을 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181879
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class Solution
        {
            public int solution(int[] num_list)
            {
                int answer = 0;
                int num = 1;
                if (num_list.Length >= 11)
                {
                    for (int i = 0; i < num_list.Length; i++)
                    {
                        answer += num_list[i];
                    }
                }
                else
                {
                    for (int i = 0; i < num_list.Length; i++)
                    {
                        
                        num *= num_list[i];
                    }
                    return num;
                }
                return answer;
            }
        }
    }
}
