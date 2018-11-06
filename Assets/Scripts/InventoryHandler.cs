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

        btnName = activeToggle.name;

        if (Input.GetMouseButtonDown(0) && ! EventSystem.current.IsPointerOverGameObject())
        {
            switch (btnName)
            {
                case "Wolf":
                    c.genCreatureAtMousePos();
                    break;
                case "Tree":
                    c.genTree();
                    break;
                case "Shroom":
                    c.genShroom();
                    break;
                default:
                    break;
            }
        }
    }
}
