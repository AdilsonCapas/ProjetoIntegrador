using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class TransactionManager : MonoBehaviour
{
    [System.Serializable]
    public class Transaction
    {
        public string description;
        public bool isRevenue;
    }

    public List<Transaction> transactions = new List<Transaction>();
    public GameObject transactionPrefab;
    public Transform transactionContainer;

    void Start()
    {
        // Exemplo de transações
        transactions.Add(new Transaction { description = "A", isRevenue = true });
        transactions.Add(new Transaction { description = "C", isRevenue = false });
        transactions.Add(new Transaction { description = "D", isRevenue = false });
        transactions.Add(new Transaction { description = "B", isRevenue = true });

        InstantiateTransactions();
    }

    void InstantiateTransactions()
    {
        foreach (var transaction in transactions)
        {
            GameObject transactionObj = Instantiate(transactionPrefab, transactionContainer);
            transactionObj.GetComponentInChildren<Text>().text = transaction.description;
            transactionObj.GetComponent<DraggableTransaction>().isRevenue = transaction.isRevenue;
        }
    }
}