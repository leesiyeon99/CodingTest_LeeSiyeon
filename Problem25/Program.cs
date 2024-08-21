namespace Problem25
/// <summary>
/// 날짜: 2024.08.22
/// 문제: 문자열 my_string이 매개변수로 주어질 때, 
/// 대문자는 소문자로 소문자는 대문자로 변환한 문자열을 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120893
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string ans = solution.solution("askldLSKDANLAsdal");
            Console.WriteLine(ans);
        }

        public class Solution
        {
            public string solution(string my_string)
            {
                string answer = "";
                for (int i = 0; i < my_string.Length; i++)
                {
                    if (char.IsUpper(my_string[i])) //대문자인지 아닌지 확인해서
                    {
                        answer += my_string[i].ToString().ToLower(); // 대문자이면 소문자로 변경
                    }
                    else
                    {
                        answer += my_string[i].ToString().ToUpper();
                    }
                }
                return answer;
            }
        }
    }
}
