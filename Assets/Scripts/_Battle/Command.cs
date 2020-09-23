using UnityEngine;

public abstract class Command : MonoBehaviour
{
    [Header("Base Settings")]

    /*
     * @commandName
     * The name of the command.
     */
    [SerializeField]
    private string commandName;
    public string GetCommandName() { return commandName; }
    public void SetCommandName(string value) => commandName = value; 

    /*
     * @commandCost
     * The cost of the command. Generally, higher tier commands cost higher.
     */
    [SerializeField]
    private int commandCost;
    public int GetCommandCost() { return commandCost; }
    public void SetCommandCost(int value) => commandCost = value;

    /*
     * @commandType
     * The type of the command. Currently, there are 3 types: Attack, Defense, Support.
     */
    [SerializeField]
    private CommandType commandType;
    private enum CommandType { Attack, Defense, Support };


    [Header("Animation Settings")]

    /*
     * @animationTime
     * The animation duration of the command.
     */
    [SerializeField]
    private int animationTime;
    public int GetAnimationTime() { return animationTime; }
    public void SetAnimationTime(int value) => animationTime = value;

    public abstract void OnCast();
}
