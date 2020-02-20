using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityNetworkingSystemTCP;

public class ClientSend : MonoBehaviour
{
    private static void SendTCPData(Packet _packet)
    {
        _packet.WriteLength();
        Client.Instance.tcp.SendData(_packet);
    }

    private static void SendUDPData(Packet _packet)
    {
        _packet.WriteLength();
        Client.Instance.udp.SendData(_packet);
    }

    #region Packets
    public static void WelcomeReceived()
    {
        using (Packet _packet = new Packet((int)ClientPackets.welcomeReceived))
        {
            _packet.Write(Client.Instance.myId);
            _packet.Write(UIManager.Instance.usernameField.text);

            SendTCPData(_packet);
        }
    }

    public static void PlayerMovement(bool[] _inputs)
    {
        using (Packet _packet = new Packet((int)ClientPackets.playerMovement))
        {
            _packet.Write(_inputs.Length);

            foreach (bool _input in _inputs)
            {
                _packet.Write(_input);
            }

            UnityEngine.Quaternion UEQuat = NGameManager.players[Client.Instance.myId].transform.rotation;

            System.Numerics.Quaternion NumQuat = new System.Numerics.Quaternion(UEQuat.x, UEQuat.y, UEQuat.z, UEQuat.w);
            _packet.Write(NumQuat);

            SendUDPData(_packet);
        }
    }
    #endregion
}
