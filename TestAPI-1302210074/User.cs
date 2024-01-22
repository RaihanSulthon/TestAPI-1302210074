using TestAPI_1302210074.Controllers;


namespace TestAPI_1302210074
{
    public class User
    {
        public string Nama { get; private set; }
        public string Nim { get; private set; }

        public User(string nama, string nim)
        {
            this.Nama = nama;
            this.Nim = nim;
        }

    }
}
