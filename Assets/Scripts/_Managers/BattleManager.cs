using UnityEngine;

public class BattleManager
{
    public enum BattleTurn { Player, Enemy };

    private BattleTurn currentTurn;
    public BattleTurn GetBattleTurn() { return currentTurn; }
    public void SetBattleTurn(BattleTurn value) { currentTurn = value; }

    [SerializeField]
    protected Enemy[] enemies;
    public Enemy[] GetEnemies() { return enemies; }
    public void SetEnemies(Enemy[] value) { enemies = value; }

    public BattleManager()
    {

    }

}
