namespace Problem12
/// <summary>
/// 날짜: 2024.08.07
/// 문제: 머쓱이네 옷가게는 10만 원 이상 사면 5%, 30만 원 이상 사면 10%, 50만 원 이상 사면 20%를 할인해줍니다.
/// 구매한 옷의 가격 price가 주어질 때, 지불해야 할 금액을 return 하도록 solution 함수를 완성해보세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120818
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int answer = solution.solution(580000);
            Console.WriteLine(answer);
            
        }

        public class Solution
        {
            public int solution(int price)
            {
                int answer = 0;
                if (price >= 500000)
                {
                    return (int)(price * 0.8);
                }
                else if (price >= 300000)
                {
                    return (int)(price * 0.9);
                }
                else if(price >= 100000)
                {
                    return (int)(price * 0.95);
                }
                else
                {
                    return price;
                }
                //만일 price - (int)(price * 할인율) 형식으로 하게 되면
                // 1. 정수형 변환에서의 손실 2. 부동소수점의 정밀도 문제 가 생기게 됨
                //(int)(price * (1 - 할인율))가 부동소수점 수의 정확한 계산이 가능함
            }
        }
    }
}
