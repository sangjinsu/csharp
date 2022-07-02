﻿namespace csharp4;

public enum GameMode
{
    None,
    Lobby,
    Town,
    Field,
}

public class Game
{
    private GameMode mode = GameMode.Lobby;
    private Player player;
    private Monster monster;
    private Random rand;

    public void Process()
    {
        switch (mode)
        {
            case GameMode.Lobby:
                ProcessLobby();
                break;
            case GameMode.Town:
                ProcessTown();
                break;
            case GameMode.Field:
                ProcessField();
                break;
        }
    }

    private void ProcessLobby()
    {
        Console.WriteLine("직업을 선택하세요");
        Console.WriteLine("[1] 기사");
        Console.WriteLine("[2] 궁수");
        Console.WriteLine("[3] 법사");

        String? input = Console.ReadLine();
        switch (input)
        {
            case "1":
                player = new Knight();
                break;
            case "2":
                player = new Archer();
                break;
            case "3":
                player = new Mage();
                break;
        }

        mode = GameMode.Town;
    }

    private void ProcessTown()
    {
        Console.WriteLine("마을에 입장했습니다");
        Console.WriteLine("[1] 필드로 가기");
        Console.WriteLine("[2] 로비로 돌아가기");

        String? input = Console.ReadLine();
        switch (input)
        {
            case "1":
                mode = GameMode.Field;
                break;
            case "2":
                mode = GameMode.Lobby;
                break;
        }
    }

    private void ProcessField()
    {
        Console.WriteLine("필드에 입장했습니다");
        Console.WriteLine("[1] 싸우기");
        Console.WriteLine("[2] 일정 확률로 마을 돌아가기");

        CreateRandomMonster();

        String? input = Console.ReadLine();
        switch (input)
        {
            case "1":
                ProcessFight();
                break;
            case "2":
                TryEscape();
                break;
        }
    }

    private void TryEscape()
    {
        var randValue = rand.Next(0, 100);
        if (randValue < 33)
        {
            mode = GameMode.Town;
        }

        ProcessFight();
    }

    private void ProcessFight()
    {
        while (true)
        {
            var damage = player.GetAttack();
            monster.OnDamaged(damage);
            if (monster.IsDead())
            {
                Console.WriteLine("승리");
                Console.WriteLine($"남은 체력{player.GetHp()}");
                break;
            }

            damage = monster.GetAttack();
            player.OnDamaged(damage);
            if (player.IsDead())
            {
                Console.WriteLine("패배");
                break;
            }
        }
    }

    private void CreateRandomMonster()
    {
        var randValue = rand.Next(0, 3);
        switch (randValue)
        {
            case 0:
                monster = new Slime();
                Console.WriteLine("슬라임이 생성되었습니다.");
                break;
            case 1:
                monster = new Orc();
                Console.WriteLine("오크가 생성되었습니다.");
                break;
            case 2:
                monster = new Skeleton();
                Console.WriteLine("스켈레톤이 생성되었습니다.");
                break;
        }
    }
}