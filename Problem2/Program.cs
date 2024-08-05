using static Problem2.Program;

namespace Problem2
{
    /// <summary>
    /// 날짜: 2024.08.12
    /// 문제: 머쓱이네 양꼬치 가게는 10인분을 먹으면 음료수 하나를 서비스로 줍니다. 
    /// 양꼬치는 1인분에 12,000원, 음료수는 2,000원입니다. 정수 n과 k가 매개변수로 주어졌을 때,
    /// 양꼬치 n인분과 음료수 k개를 먹었다면 총얼마를 지불해야 하는지 return 하도록 solution 함수를 완성해보세요.
    /// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120830
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(64, 6));
        }

        public class Solution
        {
            public int solution(int n, int k)
            {
                int answer = 0;
                int meetPrice = 12000;
                int drinkPrice = 2000;
                int serviceDrinkCount = 0;

                serviceDrinkCount =  n / 10;

                answer = (meetPrice * n) + (drinkPrice * k) - (serviceDrinkCount * drinkPrice);

              
                return answer;
            }
        }
    }
}
