using PI183_Lab2_Classes.FieldEditor;
using System.Collections.Generic;

namespace PI183_Lab2_Classes.Crossword
{

  public class PlayerField : Field
  {
    public Player Owner { get; set; }

    public PlayerField(int x, int y) : base(x, y)
    {
    }
  }

  public enum EState
  {
    Begin,
    Game,
    Timeout,
    Pause
  }


  public class Player
  {
    public Player(string name)
    {
      Name = name;
    }

    public string Name { get; set; }
  }
  public class CrosswordFight
  {

    public CSchema Schema { get; private set; }

    /// <summary>
    /// Состояние игры
    /// </summary>
    public EState State { get; private set; }
    public List<Player> Players { get; private set; }
    public int CurrentPlayer { get; private set; }

    public CrosswordFight()
    {
      State = EState.Begin;
      Players = new List<Player>()
      {
        new Player("1"), new Player("2")
      };
      Schema = new CSchema(6, 6);
      CurrentPlayer = 0;
    }

    public void Click(Field pF)
    {
      if (State != EState.Game) {
        return;
      }

      if (pF == null) {
        return;
      }

      PlayerField pPlayerField = new PlayerField(pF.X, pF.Y);
      pPlayerField.Owner = Players[CurrentPlayer];
      Schema.Exchange(pF, pPlayerField);

      h_NextTurn();
    }

    private void h_NextTurn()
    {
      CurrentPlayer++;
      if (CurrentPlayer >= Players.Count)
      {
        CurrentPlayer = 0;
      }
    }

    public void StartGame()
    {
      CurrentPlayer = 0;
      Schema.Clear();
      State = EState.Game;
    }
  }
}
