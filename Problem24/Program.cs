namespace Problem24
/// <summary>
/// 날짜: 2024.08.22
/// 문제: 군 전략가 머쓱이는 전쟁 중 적군이 다음과 같은 암호 체계를 사용한다는 것을 알아냈습니다.
///         - 암호화된 문자열 cipher를 주고받습니다.
///         - 그 문자열에서 code의 배수 번째 글자만 진짜 암호입니다.
///      문자열 cipher와 정수 code가 매개변수로 주어질 때 해독된 암호 문자열을 return하도록 
///      solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120892
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string ans = solution.solution("dfjardstddetckdaccccdegk", 4);
            Console.WriteLine(ans);
        }

        public class Solution
        {
            public string solution(string cipher, int code)
            {
                string answer = "";
                for (int i = 0; i < cipher.Length; i++)
                {
                    if ((i +1) % code == 0)
                    {
                        answer += cipher[i];
                    }
                }
                return answer;
            }
        }
    }
}
