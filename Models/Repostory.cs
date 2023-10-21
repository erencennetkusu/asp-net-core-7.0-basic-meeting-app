

namespace MeetingApp.Models
{
    public static class Repostory
    {

         private static readonly List<UserInfo> _users = new();


         static Repostory()
        {
            _users.Add(new UserInfo() { Id = 1, Name="ahmet sincan",Phone="22222",Email="abc@gmail.com",WillAttend=true});
            _users.Add(new UserInfo() { Id = 2, Name = "mehmet demir", Phone = "22222", Email = "abc@gmail.com", WillAttend = false });
            _users.Add(new UserInfo() { Id = 3, Name = "sabri ülker", Phone = "22222", Email = "abc@gmail.com", WillAttend = false });
        }
        public static List<UserInfo> Users(){
                
                return _users;
         }


         public static void CreateUser(UserInfo user){

            user.Id = _users.Count + 1;
            _users.Add(user);

         }

        public static UserInfo?  GetById( int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
        
    }
}