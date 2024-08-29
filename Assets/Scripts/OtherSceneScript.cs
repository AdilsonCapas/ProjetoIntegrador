using UnityEngine;

public class OtherSceneScript : MonoBehaviour
{
    void Start()
    {
        foreach (var item in ItemManager.Instance.itemList)
        {
            Debug.Log("Item na lista: " + item);
        }
    }
}
