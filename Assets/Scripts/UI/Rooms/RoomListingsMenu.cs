using Photon.Pun;
using Photon.Realtime;
using System.Collections.Generic;
using UnityEngine;

public class RoomListingsMenu : MonoBehaviourPunCallbacks
{
    [SerializeField] Transform _content;

    [SerializeField] RoomListing _roomListingPrefab;

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        foreach (RoomInfo info in roomList)
        {
            RoomListing listing = Instantiate(_roomListingPrefab, _content);
            if (listing != null)
            {
                listing.SetRoomInfo(info);
            }
        }
    }
}
