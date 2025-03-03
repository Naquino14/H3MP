using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Discord
{
	public partial class LobbyManager // (guess) looks therough the connected members of a server and grabs their info
	{
		public IEnumerable<User> GetMemberUsers(Int64 lobbyID)
		{
			var memberCount = MemberCount(lobbyID);
			var members = new List<User>();
			for (var i = 0; i < memberCount; i++)
			{
				members.Add(GetMemberUser(lobbyID, GetMemberUserId(lobbyID, i)));
			}
			return members;
		}

		public void SendLobbyMessage(Int64 lobbyID, string data, SendLobbyMessageHandler handler)
		{
			SendLobbyMessage(lobbyID, Encoding.UTF8.GetBytes(data), handler);
		}
	}
}
