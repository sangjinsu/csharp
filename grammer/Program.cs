namespace grammer
{
    class Program
    {
        // 제네릭
        class MyList<T>
        {
            T[] arr = new T[10];
        }

        // 추상 클래스
        abstract class Monster
        {
            public virtual void Shout()
            {
            }
        }

        // 인터페이스
        interface IFlyable
        {
            void Fly();
        }

        // 프로퍼티
        class Knight
        {
            private int hp = 100;
            private int mana = 100;

            public int Hp
            {
                get => hp;
                set => hp = value;
            }

            public int Mana { get; set; }
        }


        static void Main(string[] args)
        {
            var listInt = new MyList<int>();
        }
    }
}