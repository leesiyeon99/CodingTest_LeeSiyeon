namespace Problem5
/// <summary>
/// 날짜: 2024.08.06
/// 문제: 순서쌍이란 두 개의 숫자를 순서를 정하여 짝지어 나타낸 쌍으로 (a, b)로 표기합니다. 
/// 자연수 n이 매개변수로 주어질 때 두 숫자의 곱이 n인 자연수 순서쌍의 개수를 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120836
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int num = solution.solution(100);
            Console.WriteLine(num);
        }

        public class Solution
        {
            public int solution(int n)
            {
                int answer = 0;
                //int[] num1 = new int[n];
                //int count = 1;
                //for(int i  = 0; i < n; i++)
                //{
                //    num1 [i] = count++;
                //}
                //for (int i = 0; i < num1.Length; i++)
                //{
                //    for (int j = 0; j < num1.Length; j++)
                //    {
                //        if (num1[i] * num1[j] == n)
                //        {
                //            answer++;
                //        }
                //    }
                //}return answer;        너무 오랜시간 걸림! 실패

                for (int i =1 ;i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            answer++;
                        }
                    }
                return answer;
            }
        }
    }
}
