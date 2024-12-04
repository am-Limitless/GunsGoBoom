using Photon.Realtime;
using TMPro;
using UnityEngine;

public class RoomListing : MonoBehaviour
{
    [SerializeField] TMP_Text _text;

    public void SetRoomInfo(RoomInfo roomInfo)
    {
        _text.text = roomInfo.MaxPlayers + ", " + roomInfo.Name;
    }
}
