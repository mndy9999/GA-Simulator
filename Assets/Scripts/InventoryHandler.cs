using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Linq;
using UnityEngine.EventSystems;

public class InventoryHandler : MonoBehaviour {

    public ToggleGroup toggleGroup;
    public Toggle activeToggle;

    public CreatureCreation c;
    string name;

    private void Start()
    {
        activeToggle = null;
        name = null;
    }

    void Update()
    {
        activeToggle = toggleGroup.ActiveToggles().FirstOrDefault();
        activeToggle.GetComponentInChildren<Image>().color = Color.blue;
        name = activeToggle.name;

        if (Input.GetMouseButtonDown(0) && ! EventSystem.current.IsPointerOverGameObject())
        {
            switch (name)
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
