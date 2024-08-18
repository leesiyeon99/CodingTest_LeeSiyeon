namespace Problem15
/// <summary>
/// 날짜: 2024.08.18
/// 문제: 문자열 배열 strlist가 매개변수로 주어집니다. 
/// strlist 각 원소의 길이를 담은 배열을 retrun하도록 solution 함수를 완성해주세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120854
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string[] str = { "We", "are", "the", "world!" };
            int[] ans=solution.solution(str);
            foreach(int i in ans)
            {
                Console.Write(i+" ");
            }
        }

        public class Solution
        {
            public int[] solution(string[] strlist)
            {
                int[] answer = new int[strlist.Length];
                for (int i = 0; i < strlist.Length; i++)
                {
                    answer[i] = strlist[i].Length;
                }
                return answer;
            }
        }
    }
}
