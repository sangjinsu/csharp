namespace csharp4;

public enum MonsterType
{
    None = 0,
    Slime = 1,
    Orc = 2,
    Skeleton = 3,
}

public class Monster : Creature
{
    protected MonsterType type;

    protected Monster(MonsterType type) : base(CreatureType.Monster)
    {
        this.type = type;
    }

    public MonsterType GetMonsterType()
    {
        return type;
    }
}

public class Slime : Monster
{
    public Slime() : base(MonsterType.Slime)
    {
        SetInfo(10, 1);
    }
}

public class Orc : Monster
{
    public Orc() : base(MonsterType.Orc)
    {
        SetInfo(20, 2);
    }
}

public class Skeleton : Monster
{
    public Skeleton() : base(MonsterType.Skeleton)
    {
        SetInfo(15, 4);
    }
}