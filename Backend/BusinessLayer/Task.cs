using System;

public class Task
{
	private int id;
	private String title;
	private String description;
	private DateTime creationTime;
	private DateTime dueDate;

	public Task(int id, String title, String description, DateTime creationTime, DateTime dueDate)
	{
		this.id = id;
		this.title = title;
		this.description = description;
		this.creationTime = creationTime;
		this.dueDate = dueDate;


	}
	public int Id{
		get;
		
	}
	public String Title 
	{
        get { return title; }
		set { title = value; }
	}
	public String Description
	{
		get { return title; }
		set { title = value; }
	}
	public DateTime CreationTime
	{
		get { return CreationTime; }
	}
	public DateTime DueDate
	{
		get { return dueDate; }
		set { dueDate = value; }
	}


}
