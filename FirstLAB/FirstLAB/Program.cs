using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{

    class Queue
    {
        public string[] q;
        public int maximum;
        public int r;
        public int f;
        public Queue()
        {
            r = 0;
            f = 0;
            this.maximum = 250;
            this.q = new string[this.maximum];
        }
    }

    class Program
    {
        public static bool IsEmty(Queue q) 
        {
            if (q.f == q.r)
            {
                return true;

            }
            else
            {
                return false;

            }
        }

        public static bool IsFull(Queue q)
        {
            if ((q.maximum - q.f + q.r) % q.maximum == q.maximum)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public static int ENum(Queue q)
        {
            if (q.r == q.f)
                return 0;
            else
                return ((q.maximum - q.f) + q.r) % q.maximum;
        }

        public static void Enqueue(Queue q, string x)
        {
            try
            {
                if (ENum(q) == q.maximum - 1)
                {
                    Console.WriteLine("Error: Queue is full.");
                }
                else
                {
                    q.q[q.r] = x;
                    q.r = (q.r + 1) % q.maximum;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

        }

        public static string Dequeue(Queue q)
        {
            string tmp = "";

            if (q.f == q.r)
            {
                Console.WriteLine(" Error: Queue is empty");
            }
            else
            {
                tmp = q.q[q.f];
                q.f = (q.f + 1) % q.maximum;

            }
            return tmp;

        }

        public static void input(Queue q)
        {
            Console.Write("Nhap message : ");
            string chat = Console.ReadLine();
            string word;
            try
            {
                if (chat.Length <= 50)
                {
                    for (int i = 0; i < chat.Length; i++)
                    {
                        word = chat[i].ToString();
                        Enqueue(q, word);
                    }

                }
                else
                {
                    Console.WriteLine("qua ky tu can dien cho message");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void input1(Queue q)
        {
            Console.Write("Enter your message : ");
            string chat = Console.ReadLine();
            string word;
            if (chat.Length <= 50)
            {
                for (int i = 0; i < chat.Length; i++)
                {
                    word = chat[i].ToString();
                    Enqueue(q, word);
                }

            }
            else
            {
                Console.WriteLine("qua ky tu can dien cho message");
            }
        }
        public static void input2(Queue q)
        {
            Console.Write("Enter your message : ");
            string chat = Console.ReadLine();
            string word;
            if (chat.Length <= 50)
            {
                for (int i = 0; i < chat.Length; i++)
                {
                    word = chat[i].ToString();
                    Enqueue(q, word);
                }

            }
            else
            {
                Console.WriteLine("qua ky tu can dien cho message");
            }
        }
        public static void input3(Queue q)
        {
            Console.Write("Enter your message : ");
            string chat = Console.ReadLine();
            string word;
            if (chat.Length <= 50)
            {
                for (int i = 0; i < chat.Length; i++)
                {
                    word = chat[i].ToString();
                    Enqueue(q, word);
                }

            }
            else
            {
                Console.WriteLine("qua ky tu can dien cho message");
            }
        }
        public static void input4(Queue q)
        {
            Console.Write("Enter your message : ");
            string chat = Console.ReadLine();
            string word;
            if (chat.Length <= 50)
            {
                for (int i = 0; i < chat.Length; i++)
                {
                    word = chat[i].ToString();
                    Enqueue(q, word);
                }

            }
            else
            {
                Console.WriteLine("qua ky tu can dien cho message");
            }
        }

        public static void output(Queue q)
        {
            while (q.f != q.r)
            {
                Console.Write(Dequeue(q));
            }
        }

        public static void ChuyenMang(Queue q, Queue l)
        {
            string k;
            if (ENum(q) == q.maximum - 1)
            {
                for (int i = 0; i < ENum(q); i++)
                {
                    k = q.q[i];
                    Enqueue(l, k);
                }
                Console.Write("\nTin nhan cua ban duoc gui qua S2 la : ");
                output(l);
            }
            else
            {
                Console.WriteLine("Queue truyen vao chua day bo nho");
            }
        }

        public static void Main(string[] args)
        {
            Queue q = new Queue();
            Queue k = new Queue();
            input(q);
            input1(q);
            input2(q);
            input3(q);
            input4(q);
            ChuyenMang(q, k);
            Console.ReadLine();
        }

    }

}
