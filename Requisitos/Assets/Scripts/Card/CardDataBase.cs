using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName= "SO/DataBase")]
public class CardDataBase : ScriptableObject
{
    // Start is called before the first frame update
    public List<Card> collection;
}
