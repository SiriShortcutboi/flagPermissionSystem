using System;

class Program
{

    public static string userInput = "bruh";
    public static int permissionLevel = 0;     
    public static bool mainMenuBool = true;
    public static void main()
        {
        Permissions userPermissions = Permissions.None;
        
        ApplicationMenu();

        userPermissions = Permissions.Read | Permissions.Write;

        Console.WriteLine($"Current Permissions: {userPermissions} ");


        
        } //void main end
    

    [Flags]
    enum Permissions{
        //when we use the singular or| operator it combines/add the 2 powers we have for our new Hero/employee
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8,
        ViewReports = 16
    }

                //Permission Menu
    public static void ApplicationMenu()
    {
        //give permissions of none, read, write, delete, execute, or  viewreports
        while (mainMenuBool)
        {

            Console.WriteLine("==== Permission System ====");
            Console.WriteLine("1. Add Permission");
            Console.WriteLine("2. Show Current Permissions");
            Console.WriteLine("3. Perform Action");
            Console.WriteLine("4. Exit");

            permissionLevel = int.Parse(Console.ReadLine());
            // permissionLevel = 


            switch(Permissions(permissionLevel))
            {

                case Permissions.None:
                    Console.WriteLine("User access denied");
                    userPermissions = Permissions.None;
                    break;
                
                case Permissions.Read:
                    Console.WriteLine("User has Read access");
                    userPermissions = Permissions.Read;
                    break;
                
                case Permissions.Write:
                    Console.WriteLine("User has Write access");
                    userPermissions = Permissions.Write;
                    break;
                
                case Permissions.Delete:
                    Console.WriteLine("User has danger-zone access");
                    userPermissions = Permissions.Write;
                    break;
                
                case Permissions.Execute:
                    Console.WriteLine("User can run any program");
                    userPermissions = Permissions.Execute;
                    break;
                
                case Permissions.ViewReports:
                    Console.WriteLine("This user is a super-user, can even view reports");
                    userPermissions = Permissions.ViewReports;
                    break;
            }

            /* userPermissions = Permissions.Read | Permissions.Write;

            Console.WriteLine($"Current Permissions: {userPermissions} "); */
        }
        
    }
}