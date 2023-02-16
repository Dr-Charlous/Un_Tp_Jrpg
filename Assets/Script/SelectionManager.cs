using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    public Material MaterialOutline;
    public Material MaterialDefault;
    Character _selectedCharacter;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            if (hit.collider != null)
            {
                Character character = hit.collider.gameObject.GetComponent<Character>();
                if (character != null)
                {
                    if (_selectedCharacter != null)
                    {
                        _selectedCharacter.Visual.material = MaterialDefault;
                    }
                    _selectedCharacter = character;
                    character.Visual.material = MaterialOutline;
                }
            }
        }
    }
}