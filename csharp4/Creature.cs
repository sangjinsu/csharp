namespace csharp4;

public enum CreatureType
{
    None = 0,
    Player = 1,
    Monster = 2
}

public class Creature
{
    private CreatureType _type;
    protected int _hp;
    protected int _attack;

    protected Creature(CreatureType type)
    {
        _type = type;
    }

    public void SetInfo(int hp, int attack)
    {
        _hp = hp;
        _attack = attack;
    }

    public int GetHp()
    {
        return _hp;
    }

    public int GetAttack()
    {
        return _attack;
    }

    public bool IsDead()
    {
        return _hp <= 0;
    }

    public void OnDamaged(int damage)
    {
        _hp -= damage;
        if (_hp < 0)
        {
            _hp = 0;
        }
    }
}