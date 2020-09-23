using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseActor : MonoBehaviour
{
    [Header("Base Settings")]

    /*
     * @actorName
     * The name of the character.
     */
    [SerializeField]
    private string actorName;
    public string GetActorName() { return actorName; }
    public void SetActorName(string value) => actorName = value;

    /*
     * @actorHealth
     * The total health of the character.
     */
    [SerializeField]
    private int actorHealth;
    public int GetActorHealth() { return actorHealth; }
    public void SetActorHealth(int value) => actorHealth = value;

    /*
     * @maxCommands
     * The max amount of commands the character has. Starts at 3.
     */
    [SerializeField]
    private int maxCommands;
    public int GetMaxCommands() { return maxCommands; }
    public void SetMaxCommands(int value) => maxCommands = value;


    [Header("Attack Command Settings")]

    /*
     * @wAttackCommand
     * The Command in slot W of the character.
     */
    [SerializeField]
    private Command wAttackCommand;
    public Command GetActorWAttackCommand() { return wAttackCommand; }
    public void SetActorWAttackCommand(Command value) => wAttackCommand = value; 

    /*
     * @aAttackCommand
     * The Command in slot A of the character.
     */
    [SerializeField]
    private Command aAttackCommand;
    public Command GetActorAAttackCommand() { return aAttackCommand; }
    public void SetActorAAttackCommand(Command value) => aAttackCommand = value;

    /*
     * @sAttackCommand
     * The Command in slot S of the character.
     */
    [SerializeField]
    private Command sAttackCommand;
    public Command GetActorSAttackCommand() { return sAttackCommand; }
    public void SetActorSAttackCommand(Command value) => sAttackCommand = value;

    /*
     * @dAttackCommand
     * The Command in slot D of the character.
     */
    [SerializeField]
    private Command dAttackCommand;
    public Command GetActorDAttackCommand() { return dAttackCommand; }
    public void SetActorDAttackCommand(Command value) => dAttackCommand = value;


    [Header("Defense Command Settings")]

    /*
     * @wDefenseCommand
     * The Command in slot W of the character.
     */
    [SerializeField]
    private Command wDefenseCommand;
    public Command GetActorWDefenseCommand() { return wDefenseCommand; }
    public void SetActorWDefenseCommand(Command value) => wDefenseCommand = value;

    /*
     * @aDefenseCommand
     * The Command in slot A of the character.
     */
    [SerializeField]
    private Command aDefenseCommand;
    public Command GetActorADefenseCommand() { return aDefenseCommand; }
    public void SetActorADefenseCommand(Command value) => aDefenseCommand = value;

    /*
     * @sDefenseCommand
     * The Command in slot S of the character.
     */
    [SerializeField]
    private Command sDefenseCommand;
    public Command GetActorSDefenseCommand() { return sDefenseCommand; }
    public void SetActorSDefenseCommand(Command value) => sDefenseCommand = value;

    /*
     * @dDefenseCommand
     * The Command in slot D of the character.
     */
    [SerializeField]
    private Command dDefenseCommand;
    public Command GetActorDDefenseCommand() { return dDefenseCommand; }
    public void SetActorDDefenseCommand(Command value) => dDefenseCommand = value;
}
