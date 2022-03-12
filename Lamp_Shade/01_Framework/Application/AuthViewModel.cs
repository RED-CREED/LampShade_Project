﻿namespace _01_Framework.Application
{
	public class AuthViewModel
	{
		public long Id { get; set; }
		public long RoleId { get; set; }
		public string Role { get; set; }
		public string Fullname { get; set; }
		public string Username { get; set; }
		public List<int> Permissions { get; set; }
		public bool RememberMe { get; set; }
		public AuthViewModel()
		{

		}
		public AuthViewModel(long id, long roleId, string fullname, string username, List<int> permissions)
		{
			Id = id;
			RoleId = roleId;
			Fullname = fullname;
			Username = username;
			Permissions = permissions;
			RememberMe = false;
		}
	}
}