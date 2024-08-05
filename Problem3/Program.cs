namespace Problem3
/// <summary>
/// 날짜: 2024.08.12
/// 문제: 문자열 my_string이 매개변수로 주어질 때, my_string 안에 있는 숫자만 골라 오름차순 정렬한 리스트를
/// return 하도록 solution 함수를 작성해보세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/120850
/// </summary>
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] a = solution.MySolution("헬로우121430");
            Console.WriteLine(string.Join(",", a));
        }

        public class Solution
        {
            public int[] MySolution(string my_string)
            {
                List<int> input = new List<int>();
                my_string.ToArray();

                for (int i = 0; i < my_string.Length; i++)
                {
                    char c = my_string[i];
                    if(char.IsDigit(c))
                    {
                        input.Add(c-'0');
                    }
                    input.Sort();
                    
                }
                return input.ToArray();
            }
        }
    }
}
