namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo { Id =1, Name = "Ali Candan", Phone = "0555555555", Email="hhh@gmail.com", WillAttend = true });
            _users.Add(new UserInfo { Id =2, Name = "Hatice Kayalar", Phone = "0555544445", Email="nanang@gmail.com", WillAttend = true });
            _users.Add(new UserInfo { Id =3, Name = "Kayhan Yandan", Phone = "0555545455", Email="kfkf@gmail.com", WillAttend = false });
            _users.Add(new UserInfo { Id =4, Name = "Mustafa Yılmaz", Phone = "0558678855", Email="cmdjd@gmail.com", WillAttend = true });
        }

        public static List<UserInfo> Users 
        {
            get { return _users; }
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user=>user.Id == id);
        }
    }
}