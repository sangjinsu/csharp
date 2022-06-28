namespace csharp4;

public enum PlayerType
{
    None = 0,
    Knight = 1,
    Archer = 2,
    Mage = 3
}

class Player
{
    protected PlayerType _type;
    protected int _hp;
    protected int _attack;

    protected Player(PlayerType type)
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

class Knight : Player
{
    Knight() : base(PlayerType.Knight)
    {
        SetInfo(100, 10);
    }
}

class Archer : Player
{
    Archer() : base(PlayerType.Archer)
    {
        SetInfo(75, 13);
    }
}

class Mage : Player
{
    Mage() : base(PlayerType.Mage)
    {
        SetInfo(60, 20);
    }
}