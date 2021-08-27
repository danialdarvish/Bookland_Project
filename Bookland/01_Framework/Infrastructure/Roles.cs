namespace _01_Framework.Infrastructure
{
    public static class Roles
    {
        public const string Administrator = "1";
        public const string SystemUser = "2";
        public const string ContentCreator = "3";
        public const string ColleagueUser = "4";

        public static string GetRoleBy(long id)
        {
            switch (id)
            {
                case 1:
                    return "مدیر سیستم";
                case 2:
                    return "محتوا گذار";
                default:
                    return "";
            }
        }
    }
}
