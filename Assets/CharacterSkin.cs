using UnityEngine;

public class CharacterSkin : MonoBehaviour
{
    public Sprite[] characterSprites;

    void Start()
    {
        int id = PlayerPrefs.GetInt("SelectedCharacter", 0);

        if (characterSprites != null && characterSprites.Length > 0)
        {
            if (id < 0 || id >= characterSprites.Length)
                id = 0;

            GetComponent<SpriteRenderer>().sprite = characterSprites[id];
        }
    }
}

