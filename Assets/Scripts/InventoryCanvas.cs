using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class InventoryCanvas : MonoBehaviour
{
    public Image selectIcon;
    public TMP_Text descriptionText;
    public Transform rightPanelTransform;
    public GameObject itemButtonPrefab;

    public void OnOpen()
    {
        for (int i = rightPanelTransform.childCount - 1; i >= 0; i--)
        {
            Destroy(rightPanelTransform.GetChild(i).gameObject);
        }
        
        for (int i = 0; i < InventoryManager.instance.inventoryList.Count; i++)
            {
                GameObject itemButtonObj = Instantiate(itemButtonPrefab, rightPanelTransform);
                ItemButton itemButtonComp = itemButtonObj.GetComponent<ItemButton>();
                itemButtonComp.data = InventoryManager.instance.inventoryList[i];
                itemButtonComp.icon.sprite = itemButtonComp.data.ItemIcon;
                Button button = itemButtonObj.GetComponent<Button>();
                button.onClick.AddListener(() =>
                {
                    selectIcon.sprite = itemButtonComp.data.ItemIcon;
                    descriptionText.text = itemButtonComp.data.description;
                });
            }
    }
}
