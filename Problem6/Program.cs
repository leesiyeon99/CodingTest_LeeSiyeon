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
                OtherSolution solution = new OtherSolution();
                
                String[] input;
                Console.Clear();
                input = Console.ReadLine().Split(' ');
                string answer = solution.OtherSolution1(input);
                //Console.WriteLine(answer);

                //MySolution
                //Queue<String> queue = new Queue<String>();
                //foreach (String s in input)
                //{
                //    queue.Enqueue(s);
                //    Console.Write(s);
                //}

            }

            public class OtherSolution
            {
                public string OtherSolution1(string[] input)
                {
                    String s1 = input[0];
                    String s2 = input[1];
                    Console.WriteLine($"{s1}{s2}");
                    return (s1 + s2);
                    
                }
            }
        }
    }
}
