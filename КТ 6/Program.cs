using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            List<INotifier> notifiers = new List<INotifier>
            {
                new EmailNotifier(),
                new SmsNotifier(),
                new TelegramNotifier()
            };

            foreach (var notifier in notifiers)
            {
                notifier.Send("Интерфейсы — это круто!");
            }
            Console.ReadLine();
        }
    }
    
    public interface INotifier
    {
        void Send(string message);
    }
    
    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("Новое письмо на вашем Email: " + message);
        }
    }

    public class SmsNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("Новое сообщение в СМС: " + message);
        }
    }

    public class TelegramNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("Новое сообщение в Telegram: " + message);
        }
    }
}