using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance;

    public List<string> itemList = new List<string>();

    public GameObject itemPrefab; // Prefab do item
    public Transform contentPanel; // Painel onde os itens serão exibidos (por exemplo, um GridLayout)

    private void Awake()
    {
        // Implementa o padrão Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddItem(string item)
    {
        itemList.Add(item);
        Debug.Log("Item adicionado: " + item);

        // Instanciar o prefab na tela
        GameObject newItem = Instantiate(itemPrefab, contentPanel);
        newItem.GetComponentInChildren<UnityEngine.UI.Text>().text = item; // Define o texto do item, se aplicável
    }
}
