using System;

class Program
{

    public static string userInput = "bruh";
    public static Permissions userPermissions;     
    public static bool mainMenuBool = true;
    public static void Main()
    {
        // Permissions userPermissions = Permissions.None;
        //System.Console.WriteLine((int)userPermissions);


        ApplicationMenu();

        //userPermissions = Permissions.Read | Permissions.Write;

        //Console.WriteLine($"Current Permissions: {userPermissions} ");


        
    } //void main end
    

    [Flags]
    public enum Permissions{
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

            int action = int.Parse(Console.ReadLine());
                        //need to make this an if statement to run a choice isntead of all 3
            // 1. RunAddPermissionMethod
            AddPermissionMethod();
            // 2. Display permission
            DisplayPermissionMethod();
            // 3. display text from permission
             DisplayPermissionTextMethod();
            // 4. break; - set mainMenuBool to false
            // permissionLevel = 


  
            /* userPermissions = Permissions.Read | Permissions.Write;

            Console.WriteLine($"Current Permissions: {userPermissions} "); */
        }    
    }
    public static void AddPermissionMethod()
    {
        //which permission to add
        Permissions response = Permissions.Read;
        switch(response)
        {
            case Permissions.None:                    
                userPermissions |= Permissions.None;
                break;                
            case Permissions.Read:                    
                userPermissions |= Permissions.Read;
                break;                
            case Permissions.Write:                    
                userPermissions |= Permissions.Write;
                break;                
            case Permissions.Delete:                    
                userPermissions |= Permissions.Write;
                break;                
            case Permissions.Execute:                   
                userPermissions |= Permissions.Execute;
                break;                
            case Permissions.ViewReports:                    
                userPermissions |= Permissions.ViewReports;
                break;
        }

    }
    public static void DisplayPermissionMethod()
    {
        System.Console.WriteLine(userPermissions2);
    }
    public static void DisplayPermissionTextMethod()
    {
                //which permission text to see
        Permissions response = Permissions.Read;
        switch(response)
        {

            case Permissions.None:
                Console.WriteLine("User access denied");
                break;                
            case Permissions.Read:
                Console.WriteLine("User has Read access");
                break;                
            case Permissions.Write:
                Console.WriteLine("User has Write access");
                break;                
            case Permissions.Delete:
                Console.WriteLine("User has danger-zone access");
                break;                
            case Permissions.Execute:
                Console.WriteLine("User can run any program");
                break;                
            case Permissions.ViewReports:
                Console.WriteLine("This user is a super-user, can even view reports");
                break;

            //NOTES TO IMPLEMENT: dISPLAY WORKS GOOD, checked off, copy things off that
                // for feature building 
                //1 Need to make sure Users can type the String to select the permission they want
                //2 Need to add decision logic to display those different menu items
                    //lines 1 and 2 right there important, 2 might have to be implemented first
                    //Mr Jensen said you can use integers if you want, sounds harder though, 
                    //Our permissions uses int and string, its not that deep
                /*
                //NEED TO CHANGE THE HARDCODED 2 BACK TO USER INPUT FOR ANY PERMISSION SYSTEM SELECTION
                ==== Permission System ====
                    1. Add Permission
                    2. Show Current Permissions
                    3. Perform Action
                    4. Exit
                    2 """entered 2, its hardcoded at about line 96  System.Console.WriteLine(userPermissions2);"""
                    Read
                    User has Read access 
                                */
            //these might be the same but i swear they are on line 102 and line 71, look at the commit.
            //need to change the hardcoding on line 71
        }

    }
}