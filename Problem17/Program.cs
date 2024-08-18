namespace Problem17
/// <summary>
/// 날짜: 2024.08.18
/// 문제: 문자열 str1, str2가 매개변수로 주어집니다. str1 안에 str2가 있다면 1을 없다면 
/// 2를 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120908
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "ab6CDE443fgh22iJKlmn1o";
            Solution solution = new Solution();
            int ans = solution.solution(a, "6CD");
            Console.WriteLine(ans);
        }

        public class Solution
        {
            public int solution(string str1, string str2)
            {
                int answer = 0;
                if (str1.Contains(str2))
                {
                    answer = 1;
                }
                else
                {
                    answer = 2;
                }
                return answer;
            }
        }
    }
}
