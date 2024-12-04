using UnityEngine;

[CreateAssetMenu(menuName = "Manager/GameSettings")]
public class GameSettings : ScriptableObject
{
    [SerializeField] string _gameVersion = "0.0.0";

    public string GameVersion { get { return _gameVersion; } }

    [SerializeField] string _nickName = "SuperGokul";

    public string NickName
    {
        get
        {
            int value = Random.Range(0, 9999);
            return _nickName + value;
        }
    }

}
