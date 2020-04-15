using System;

public class User
{
	private String email;
	private String password;
	private String nickname;

	public User(String email,String password,String nickname)
	{
		this.email = email;
		this.password = password;
		this.nickname = nickname;
	}
	public bool correctPass(String password)
    {
		return this.password = password;
    }
	public void editPass(String newPass,String oldPass)
    {
		if (correctPass(oldPass))
			this.password = newPass;
    }
	public void changeNickname(String newNick)
    {
		this.nickname = newNick;
    }
    
}
