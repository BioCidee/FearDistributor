using UnityEngine;

[CreateAssetMenu(fileName = "BaseProduit", menuName = "Scriptable Objects/SO_BaseProduit")]
public class SO_BaseProduit : ScriptableObject
{
    public float price;
    public string name;
    public int id;
}
