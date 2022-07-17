namespace reflection;

class Program
{
    class Important : System.Attribute
    {
        string message;

        public Important(string message)
        {
            this.message = message;
        }
    }

    class Monster
    {
        [Important("Important!")] public int hp;
        protected int attack;
        private float speed;

        void Attack()
        {
        }
    }

    static void Main(string[] args)
    {
        var monster = new Monster();
        var type = monster.GetType();
        var hashCode = monster.GetHashCode();
        var s = monster.ToString();
        var fieldInfos =
            type.GetFields(
                System.Reflection.BindingFlags.Public
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static
                | System.Reflection.BindingFlags.Instance);

        foreach (var fieldInfo in fieldInfos)
        {
            var customAttributes = fieldInfo.GetCustomAttributes(true);
            Console.WriteLine(customAttributes);
            Console.WriteLine($"{fieldInfo.Attributes} {fieldInfo.FieldType.Name} {fieldInfo.Name}");
        }
    }
}