using System;

class Program
{
   
    public static void main()
    {
    Permissions userPermissions = Permissions.None;
    } 
    

    [Flags]
    enum Permissions{
        //when we use the or | it combines/add the 2 powers we have for our new Hero
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8,
        ViewReports = 16
    }


    public static void mainMenu()
    {
        
    }
}