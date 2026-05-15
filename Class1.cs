using System;
using System.Globalization;

public interface IData
{
    public string GetData();
}
public interface IName:IData
{
    public string GetName();
}
public class Person : IName 
{
    public string GetData()
    {
        return "Data";
    }
    public string GetName()
    {
        return "Person";
    }
}