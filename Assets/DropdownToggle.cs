using UnityEngine;

public class DropdownToggle : MonoBehaviour
{
    public GameObject levelDropdown;

    public void ToggleDropdown()
    {
        levelDropdown.SetActive(!levelDropdown.activeSelf);
    }
}

