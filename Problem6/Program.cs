namespace Problem6
/// <summary>
/// 날짜: 2024.08.06
/// 문제: 두 개의 문자열 str1, str2가 공백으로 구분되어 입력으로 주어집니다.
/// 입출력 예와 같이 str1과 str2을 이어서 출력하는 코드를 작성해 보세요.
/// URL: https://school.programmers.co.kr/learn/courses/30/lessons/181946
/// </summary>
{
    internal class Program
    {
        public class Example
        {
            public static void Main()
            {
                String[] input;

                Console.Clear();
                input = Console.ReadLine().Split(' ');

                Queue<String> queue = new Queue<String>();
                foreach (String s in input)
                {
                    queue.Enqueue(s);
                    Console.Write(s);
                }

            }
        }
    }
}
