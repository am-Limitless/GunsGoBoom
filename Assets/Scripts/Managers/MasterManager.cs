using UnityEngine;

[CreateAssetMenu(menuName = "Singletons/MasterManager")]
public class MasterManager : SingletonScriptableObject<MasterManager>
{
    [SerializeField] GameSettings _gameSettings;

    public static GameSettings GameSettings { get { return Instance._gameSettings; } }
}
