namespace Problem30
/// <summary>
/// 날짜: 2024.08.26
/// 문제: 정수 배열 arr가 주어집니다. arr의 각 원소에 대해 값이 50보다 크거나 같은 짝수라면 2로 나누고,
/// 50보다 작은 홀수라면 2를 곱합니다. 그 결과인 정수 배열을 return 하는 solution 함수를 완성해 주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181882
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
            public int[] solution(int[] arr)
            {
                int[] answer = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] >= 50 && arr[i] % 2 == 0)
                    {
                        answer[i] = arr[i] / 2;
                    }
                    else if (arr[i] <= 50 && arr[i] % 2 != 0)
                    {
                        answer[i] = arr[i] * 2;
                    }
                    else
                    {
                        answer[i] = arr[i];
                    }
                }
                return answer;
            }
        }
    }
}
