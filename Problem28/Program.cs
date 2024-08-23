namespace Problem28
/// <summary>
/// 날짜: 2024.08.23
/// 문제: 알파벳으로 이루어진 문자열 myString이 주어집니다. 모든 알파벳을 대문자로 변환하여 return 하는 solution 함수를 완성해 주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181877
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
            public string solution(string myString)
            {
                string answer = "";
                answer = myString.ToUpper();
                return answer;
            }
        }
    }
}
