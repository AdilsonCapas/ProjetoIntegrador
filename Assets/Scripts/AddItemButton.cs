using UnityEngine;

public class AddItemButton : MonoBehaviour
{
    public void OnAddItemButtonClicked()
    {
        ItemManager.Instance.AddItem("Novo Item");
    }
}
