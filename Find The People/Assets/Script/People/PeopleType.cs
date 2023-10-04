using UnityEngine;

public enum Gender {Women, Man}
public enum HairColor {Purple, Orange, Brown, Yellow, Blue, Pink, Gray, Black, Bald}
public enum Under{Short, Jean, Trousers}

[CreateAssetMenu(fileName = "New People Type", menuName = "People Type")]
public class PeopleType : ScriptableObject
{
    public string id;
    public Gender gender;
    public HairColor hairColor;
    public Under under;
}

