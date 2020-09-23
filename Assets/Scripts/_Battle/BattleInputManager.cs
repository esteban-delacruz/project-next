using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class BattleInputManager : MonoBehaviour
{
    [SerializeField]
    protected BaseActor actor;

    [SerializeField]
    protected UIBattleManager UIBattleManager;

    private List<Command> activeCommands;

    void Start()
    {
        activeCommands = new List<Command>();
        UIBattleManager.InitCanvas();
        UIBattleManager.SetCommandAttackButtons(actor);
    }

    void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            AddInputCommand(actor.GetActorWAttackCommand());
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            AddInputCommand(actor.GetActorAAttackCommand());
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            AddInputCommand(actor.GetActorSAttackCommand());
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            AddInputCommand(actor.GetActorDAttackCommand());
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            BackspaceLastCommand();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(ExecuteAllCommands());
        }
    }

    private void AddInputCommand(Command command)
    {
        if(!command)
        {
            Debug.LogError("Cannot add undefined command");
            return;
        }

        if (activeCommands.Count < actor.GetMaxCommands())
        {
            Debug.Log("Adding Command: " + command.GetCommandName() + " with a cost of: " + command.GetCommandCost());
            activeCommands.Add(command);
            UIBattleManager.AddInputCommandUI(command, activeCommands.Count);
        }
        else
        {
            Debug.LogWarning("Max number of commands reached.");
        }
    }

    private void BackspaceLastCommand()
    {
        if (activeCommands.Count > 0)
        {
            Debug.Log("Removing command: " + activeCommands[activeCommands.Count - 1]);
            activeCommands.RemoveAt(activeCommands.Count - 1);
        }
    }

    IEnumerator ExecuteAllCommands()
    {
        if (!activeCommands.Any())
        {
            Debug.LogWarning("No active commands to execute");
            yield return null;
        }

        foreach(Command command in activeCommands.ToList())
        {
            yield return StartCoroutine(ExecuteCommand(command));
        }


        Debug.Log("Excecuted all commands.");
    }

    IEnumerator ExecuteCommand(Command command)
    {
        if (!command)
        {
            yield return null;
        }

        Debug.Log("Executing command: " + command);
        activeCommands.RemoveAt(activeCommands.Count - 1);
        yield return new WaitForSeconds(command.GetAnimationTime());
    }
    
}
