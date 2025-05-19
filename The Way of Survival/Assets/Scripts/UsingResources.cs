using UnityEngine;
using UnityEngine.InputSystem;

public class UsingResources : MonoBehaviour
{
    [SerializeField] InputActionReference useFoodAction;
    [SerializeField] InputActionReference useMedAction;
    [SerializeField] Player player;
    void Start()
    {
        useFoodAction.action.performed += ctx => TryUseFood();
        useMedAction.action.performed += ctx => TryUseMed();
        useFoodAction.action.Enable();
        useMedAction.action.Enable();
    }
    void TryUseFood()
    {
        if ((player.food > 0) && (player.hunger < 100))
        {
            player.food--;
            player.hunger += 20;
        }
    }
    void TryUseMed()
    {
        if ((player.med > 0) && (player.health < 100))
        {
            player.med--;
            player.health += 50;
        }
    }
}
