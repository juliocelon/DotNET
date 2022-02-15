using System;
namespace DotNetTopics
{
    public enum Role
    {
        Developer = 5,
        SysAdmin = 10,
        Manager = 15
    }

    public enum Role2 : short
    {
        Developer1 = 5,
        SysAdmin2 = 10,
        Manager3 = 15
    }

    public class Enums
    {
        public static void Execute()
        {
            Role role = Role.Developer;

            switch (role)
            {
                case Role.Manager:
                    Console.WriteLine(Role.Manager);
                    break;
                case Role.SysAdmin:
                    Console.WriteLine(Role.SysAdmin);
                    break;
                case Role.Developer:
                    Console.WriteLine(Role.Developer);
                    break;
            }
        }
    }
}
