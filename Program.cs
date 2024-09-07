using HW_004_02_09_2024;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

class Program
{
    static void Main()
    {
        //Реализовать 2 класса: «Пользователь» и «Настройки пользователя». 
        //Организовать между таблицами связь один к одному.
        //Добавить несколько пользователей и их настройки.
        //Достать пользователя с Id = 2 и его настройки.
        //Удалить пользователя с Id 3(автоматически должен удалится профайл пользователя).

        using (ApplicationlContext db = new ApplicationlContext())
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            User user1 = new User { UserLogin = "Login1", UserPassword = "qwerty" };
            User user2 = new User { UserLogin = "Login2", UserPassword = "qwerty" };
            User user3 = new User { UserLogin = "Login3", UserPassword = "qwerty" };
            User user4 = new User { UserLogin = "Login4", UserPassword = "qwerty" };
            User user5 = new User { UserLogin = "Login5", UserPassword = "qwerty" };
            UserSettings userset1 = new UserSettings { UserName = "Alex", UserSurname = "Bob", UserPhone = " +346484512343", UserAddress = " Odessa ", UserEmail = "user@gmail.com" };
            UserSettings userset2 = new UserSettings { UserName = "Alex", UserSurname = "Bob", UserPhone = " +346484512343", UserAddress = " Odessa ", UserEmail = "user@gmail.com" };
            UserSettings userset3 = new UserSettings { UserName = "Alex", UserSurname = "Bob", UserPhone = " +346484512343", UserAddress = " Odessa ", UserEmail = "user@gmail.com" };
            UserSettings userset4 = new UserSettings { UserName = "Alex", UserSurname = "Bob", UserPhone = " +346484512343", UserAddress = " Odessa ", UserEmail = "user@gmail.com" };
            UserSettings userset5 = new UserSettings { UserName = "Alex", UserSurname = "Bob", UserPhone = " +346484512343", UserAddress = " Odessa ", UserEmail = "user@gmail.com" };
            db.Users.AddRange(user1, user2, user3, user4, user5);
            db.UsersSettings.AddRange(userset1, userset2, userset3, userset4, userset5);
        }
        using (ApplicationlContext db = new ApplicationlContext())
            {
            //Достать пользователя с Id = 2 и его настройки.
            var userSet = db.Users.Include(e=>e.Settings).FirstOrDefault(u => u.UserId == 2);
            //Удалить пользователя с Id 3(автоматически должен удалится профайл пользователя).
            var userToDelete = db.Users.Include(u => u.Settings).FirstOrDefault(u => u.UserId == 3);

            if (userToDelete != null)
            {
                db.Users.Remove(userToDelete);
            }
            db.SaveChanges();
        }
    }
}
