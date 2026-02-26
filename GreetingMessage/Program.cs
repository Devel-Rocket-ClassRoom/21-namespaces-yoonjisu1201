using System;
using formal = Formal.Message;
using casual = Casual.Message;

// README.md를 읽고 아래에 코드를 작성하세요.
formal formal = new formal();
casual casual = new casual();

Console.WriteLine("=== 인사 테스트 ===");
Console.WriteLine("[격식체]");
formal.SayHello("홍길동");
formal.SayBye("홍길동");
Console.WriteLine();

Console.WriteLine("[비격식체]");
casual.SayHello("철수");
casual.SayBye("철수");
namespace Formal
{
    class Message
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"{name}님, 안녕하십니까!");
        }

        public void SayBye(string name)
        {
            Console.WriteLine($"{name}님, 안녕히 가십시오!");
        }
    }
}

namespace Casual
{

    class Message
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"안녕, [{name}]!");
        }
        public void SayBye(string name)
        {
            Console.WriteLine($"잘 가, [{name}]!");
        }
    }
}