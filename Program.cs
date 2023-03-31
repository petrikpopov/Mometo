using System;
using System.Collections.Generic;

namespace Momento_31._03._23
{
    class Program
    {
        public class Momento
        {
            public string Font { set; get; } // шрифт 
            public int Size { set; get; } // размер

            public Momento() { }
            public Momento(string F, int S)
            {
                Font = F;
                Size = S;
            }
        }
        public class Text_Tedactor
        {
            public string Font { set; get; } // шрифт 
            public int Size { set; get; } // размер

            public Text_Tedactor() { }
            public Text_Tedactor(string f, int s)
            {
                Font = f;
                Size = s;
            }

            public void Show(string f,int s)
            {
                Console.WriteLine($"Шрифт:{Font}\nРазмер:{Size}\n");
            }

            public Momento SaveMomento()//сохранение
            {
                Console.WriteLine("Save_Momento!!");
                return new Momento(Font,Size);
            }

            public void RestoreMomento(Momento momento)//востановление
            {
                this.Font = momento.Font;
                this.Size = momento.Size;
            }
        }
        public class Caratacer
        {
            public List<Momento> momentos;

            public Caratacer()
            {
                momentos = new List<Momento>();
            }

            public void Add(Momento m)
            {
                momentos.Add(m);
            }
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Text_Tedactor text = new Text_Tedactor();
            text.Show("Жирный",12);
            Caratacer caratacer = new Caratacer();
            caratacer.Add(text.SaveMomento());
           
        }
    }
}
