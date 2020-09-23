using Boo.Lang;
using UnityEngine;
using UnityEngine.UI;

public class UIBattleManager : MonoBehaviour
{
    [SerializeField]
    protected Button wCommandButton, aCommandButton, sCommandButton, dCommandButton;

    [SerializeField]
    protected GameObject commandEntry;

    private Canvas canvas;
    private List<Vector3> commandEntryPositions;

    public void InitCanvas()
    {
        canvas = FindObjectOfType<Canvas>();
    }

    public void SetCommandEntryPositions()
    {
        commandEntryPositions.Add(new Vector3(0, 0, 0));
        commandEntryPositions.Add(new Vector3(-484, -64, 227));
        commandEntryPositions.Add(new Vector3(-275, -64, 227));
        commandEntryPositions.Add(new Vector3(-69, -64, 227));
    }

    public void SetCommandAttackButtons(BaseActor actor)
    {
        if (actor.GetActorWAttackCommand() != null)
        {
            SetButtonText(wCommandButton, "[W] " + actor.GetActorWAttackCommand().GetCommandName());
        } 
        else
        {
            SetButtonText(wCommandButton, "[W] Empty");
        }

        if (actor.GetActorAAttackCommand() != null)
        {
            SetButtonText(aCommandButton, "[A] " + actor.GetActorAAttackCommand().GetCommandName());
        }
        else
        {
            SetButtonText(aCommandButton, "[A] Empty");
        }

        if (actor.GetActorSAttackCommand() != null)
        {
            SetButtonText(sCommandButton, "[S] " + actor.GetActorSAttackCommand().GetCommandName());
        }
        else
        {
            SetButtonText(sCommandButton, "[S] Empty");
        }

        if (actor.GetActorDAttackCommand() != null)
        {
            SetButtonText(dCommandButton, "[D] " + actor.GetActorDAttackCommand().GetCommandName());
        }
        else
        {
            SetButtonText(dCommandButton, "[D] Empty");
        }
    }

    public void SetCommandDefenseButtons(BaseActor actor)
    {
        if (actor.GetActorWDefenseCommand() != null)
        {
            SetButtonText(wCommandButton, "[W] " + actor.GetActorWDefenseCommand().GetCommandName());
        }
        else
        {
            SetButtonText(wCommandButton, "[W] Empty");
        }

        if (actor.GetActorADefenseCommand() != null)
        {
            SetButtonText(aCommandButton, "[A] " + actor.GetActorADefenseCommand().GetCommandName());
        }
        else
        {
            SetButtonText(aCommandButton, "[A] Empty");
        }

        if (actor.GetActorSDefenseCommand() != null)
        {
            SetButtonText(sCommandButton, "[S] " + actor.GetActorSDefenseCommand().GetCommandName());
        }
        else
        {
            SetButtonText(sCommandButton, "[S] Empty");
        }

        if (actor.GetActorDDefenseCommand() != null)
        {
            SetButtonText(dCommandButton, "[D] " + actor.GetActorDDefenseCommand().GetCommandName());
        }
        else
        {
            SetButtonText(dCommandButton, "[D] Empty");
        }
    }

    public void AddInputCommandUI(Command command, int activeCommandsIndex)
    {
        GameObject newCommandEntry = Instantiate(commandEntry, commandEntryPositions[activeCommandsIndex], Quaternion.identity);
        Debug.Log("Command Entry: " + newCommandEntry);
        // newCommandEntry.GetComponentInChildren<Text>().text = command.GetCommandName();
        // .transform.SetParent(canvas.transform, false);
    }

    private void SetButtonText(Button button, string text) => button.GetComponentInChildren<Text>().text = text;
}
