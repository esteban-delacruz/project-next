using UnityEngine;

public abstract class Enemy
{
    [Header("Base Settings")]

    /*
     * @enemyName
     * The name of the enemy.
     */
    [SerializeField]
    private string enemyName;
    public string GetEnemyName() { return enemyName; }
    public void SetEnemyName(string value) => enemyName = value;

    /*
     * @enemyHealth
     * The total health of the enemy.
     */
    [SerializeField]
    private int enemyHealth;
    public int GetEnemyHealth() { return enemyHealth; }
    public void SetEnemyHealth(int value) => enemyHealth = value;

    /*
     * @guardBreakMeter
     * The total Guard Break Meter of the enemy.
     */
    [SerializeField]
    private int guardBreakMeter;
    public int GetGuardBreakMeter() { return guardBreakMeter; }
    public void SetGuardBreakMeter(int value) => guardBreakMeter = value;


    [Header("Command Settings")]

    /*
     * @wAttackCommand
     * The Command in slot W of the enemy.
     */
    [SerializeField]
    private Command wCommand;
    public Command GetActorWCommand() { return wCommand; }
    public void SetActorWCommand(Command value) => wCommand = value;

    /*
     * @aAttackCommand
     * The Command in slot A of the enemy.
     */
    [SerializeField]
    private Command aCommand;
    public Command GetActorACommand() { return aCommand; }
    public void SetActorACommand(Command value) => aCommand = value;

    /*
     * @sAttackCommand
     * The Command in slot S of the enemy.
     */
    [SerializeField]
    private Command sCommand;
    public Command GetActorSCommand() { return sCommand; }
    public void SetActorSCommand(Command value) => sCommand = value;

    /*
     * @dAttackCommand
     * The Command in slot D of the enemy.
     */
    [SerializeField]
    private Command dCommand;
    public Command GetActorDCommand() { return dCommand; }
    public void SetActorDCommand(Command value) => dCommand = value;
}
