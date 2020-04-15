using System;
using System.Collections.Generic;

public class Column
{
	private Dictionary<int, Task> tasks;
	private int limit;
	private int taskCounter;

    public Dictionary<int, Task> Tasks { get => tasks; set => tasks = value; }

    public Column(int limit)
	{
		this.limit = limit;
		this.taskCounter = 0;
		this.Tasks = new Dictionary<int, Task>();
	}

	public Task getTask( Task task)
    {
        if (Tasks.TryGetValue(task.Id,out Task value) )
		{
		return value;
		}
		else
		return null;

	}
	public void addTask(Task task)
    {
		if (hasTask(task))
			taskCounter =taskCounter++;
		Tasks.Add(task.Id,task);
	}
	public void removeTask(Task task)
	{
		Tasks.Remove(task.Id);
		taskCounter = taskCounter - 1;
	}
	public bool isFull()
    {
		return limit == taskCounter;
    }
	public bool hasTask(Task task)
    {
		if (Tasks.TryGetValue(task.Id,out Task value))

			return true;
		else
			return false;
    }

}
