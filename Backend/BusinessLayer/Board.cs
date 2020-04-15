using System;

public class Board
{
 
    private Column[] columns;

    public Board() => columns = new Column[3];
    public bool canMove(int columnId)
    {
        return columnId < columns.Length - 1;
    }
    public void move(int columnId, Task task)
    {
        columns[columnId + 1].addTask(columns[columnId].Tasks[task.Id]);
        columns[columnId].removeTask(task);
    }
    public void addTask(int columnId, Task task)
    {
        columns[0].addTask(task);
    }
    public bool isFull(int columnId)
    {
        //do check in boardcontroller if columnid is legal
        return columns[columnId].isFull();
    }
    public Task getTask(Task task)
    {
        for(int i=0;i<columns.Length;i++)
        {
            if(columns[i].hasTask(task)){
                
                return  columns[i].getTask(task);
            }
        }
        return null;
    }
    public void deleteTask(Task task)
    {
        for(int i=0;i<columns.Length;i++)
        {
            if(columns[i].hasTask(task)){
                
                columns[i].removeTask(task);
            }
        }
    }
    public bool hasTask(Task task)
    {
        for(int i=0;i<columns.Length;i++)
        {
            if(columns[i].hasTask(task)){
                
               return true;
            }
        }
        return false;
    }
}
