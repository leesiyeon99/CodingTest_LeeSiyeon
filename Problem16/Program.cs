namespace Problem16
/// <summary>
/// 날짜: 2024.08.18
/// 문제: 문자열 my_string과 문자 letter이 매개변수로 주어집니다.
/// my_string에서 letter를 제거한 문자열을 return하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120826
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string asn = solution.solution("asdafdf", "a");
            Console.WriteLine(asn);
        }

        public class Solution
        {
            public string solution(string my_string, string letter)
            {
                string answer = "";
                List<string> list = new List<string>();
                for (int i = 0; i < my_string.Length; i++)
                {
                    list.Add(my_string[i].ToString());
                }
                for (int i = 0; i < list.Count; i++)
                {
                    list.Remove(letter);
                }
                for(int i = 0; i< list.Count; i++)
                {
                    answer += list[i].ToString();
                }
                return answer;
            }
        }
    }
}
