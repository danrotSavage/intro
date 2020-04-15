using System;

public class BoardController
{
	private Dictionary<String, Board> boards;

    public  Dictionary<String, Board> Boards 
    { 
        get => boards;
        set => boards = value;
    }

    public BoardController() 
    { 
        Boards = new Dictionary<String, Board>();
    }
    public Board getBoard(String email)
    {
        if(Boards.TryGetValue(email,out Board value))
        {
            return value;
        }
        else
        {
            return null;
        }
    }
    public Board addBoard(String email)
    {
       
        if(!hasBoard(email))
        Boards.add(email,new Board());
    }
    public void DeleteBoard(String email)
    {

        Boards.remove(email);

    }
    public bool hasBoard(String email)
    {
        if(boards.ContainsKey(email))
        {
            return true;
        }
        else
        {
            return false;
        }
    
    }
    public bool changeEmail(String email,String newEmail)
    {
        Board newb = this.getBoard(email);
        this.DeleteBoard(email);
        this.addBoard(newEmail, newb);
    }



}
