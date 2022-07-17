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

        // Delegate
        delegate int OnClicked();
        // 반환 int 입력 void 
        // OnClicked 이 delegate 형식의 이름

        static void ButtonPressed(OnClicked clickedFunction)
        {
            clickedFunction();
        }

        static int TestDelegate()
        {
            Console.WriteLine();
            return 0;
        }

        // Event Observer Pattern
        class InputManager
        {
            public delegate void OnInputKey();

            public event OnInputKey InputKey;

            public void Update()
            {
                if (Console.KeyAvailable == false)
                {
                    return;
                }

                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.A)
                {
                    //모두에게 알려준다 
                    InputKey();
                }
            }
        }

        static void OnInputTest()
        {
            Console.WriteLine("Input Received!");
        }
        
        // lambda
        // 일회용 함수를 만드는데 사용하는 문법이다 

        static void Main(string[] args)
        {
            // var inputManager = new InputManager();
            // inputManager.InputKey += OnInputTest;
            //
            // while (true)
            // {
            //     inputManager.Update();
            // }
            
            // 익명 함수 
            // var item = FindItem((Item item) => {return item.ItemType == ItemType.Weapon})
            
            // delegate 를 직접 선언하지 않아도 이미 만들어져있다
            // 반환 타입이 있는 경우 Func
            // 반환타입이 없으면 Action 
        }
    }
}