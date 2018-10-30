using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Linq;
using UnityEngine.EventSystems;

public class InventoryHandler : MonoBehaviour {

    public ToggleGroup toggleGroup;
    public Toggle activeToggle;

    public CreatureCreation c;
    string btnName;

    private void Start()
    {
        activeToggle = null;
        btnName = null;
    }

    void Update()
    {
        activeToggle = toggleGroup.ActiveToggles().FirstOrDefault();
        toggleGroup.GetComponentInChildren<Toggle>().GetComponentInChildren<Image>().color = Color.white;
        //toggleGroup.GetComponentInChildren<Image>().color = Color.red;
        activeToggle.GetComponentInChildren<Image>().color = Color.blue;
        btnName = activeToggle.name;

        if (Input.GetMouseButtonDown(0) && ! EventSystem.current.IsPointerOverGameObject())
        {
            switch (btnName)
            {
                case "Wolf":
                    c.genCreature();
                    break;
                case "Tree":
                    c.genTree();
                    break;
                default:
                    break;
            }
        }
    }
}
