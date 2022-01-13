namespace TestCode1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 10회 반복
            int total = 10;
            for (int i = 1; i <= t
                //형철님 바보!!@@!!


                // 1~5회 시
                if (i <= (total / 2)) {
                    // 공백4->3->2->1->0 순으로 가기위해 전체반복횟수의 절반에서 1을빼줌(첫공백갯수)
                    // 그리고 차례대로 공백안찍기까지 반복
                    // 새로운 코드
                    for (int n = (total / 2) - 1; n >= i; n--)
                    {
                        Console.Write(" ");
                    }
                    // 별 1->3->5->7->9 순으로 가기위해(2개씩 늘어야 삼각형 성립)
                    // 1을 빼주지 않으면 시작별이 2부터 시작함
                    for (int t = 1; t <= 2 * i - 1; t++)
                    {
                        Console.Write("*");
                    }
                }
                // 6~10회 시
                else
                {
                    // 공백 1->2->3->4->5 순으로 가기 진행
                    for (int n = 1; n <= (i - (total / 2)); n++)
                    {
                        Console.Write(" ");
                    }

                    // 별 7->5->3->1->0 순으로 가기 진행
                    for (int t = 2 * total - 2; t >= 2 * i; t--)
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine(""); 
            }


        }

    }
}