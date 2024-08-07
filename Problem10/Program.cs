namespace Problem10
/// <summary>
/// 날짜: 2024.08.07
/// 문제: 머쓱이네 피자가게는 피자를 일곱 조각으로 잘라 줍니다. 피자를 나눠먹을 사람의 수 n이 주어질 때, 
/// 모든 사람이 피자를 한 조각 이상 먹기 위해 필요한 피자의 수를 return 하는 solution 함수를 완성해보세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120814
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int answer = solution.solution(15);
            Console.WriteLine(answer);
        }

        public class Solution
        {
            public int solution(int n)
            {
                int answer = 0;

                if ( n % 7 == 0)
                {
                    answer = n / 7;
                }
                else
                {
                    answer = n / 7 + 1;
                }
                return answer;
            }
        }
    }
}
