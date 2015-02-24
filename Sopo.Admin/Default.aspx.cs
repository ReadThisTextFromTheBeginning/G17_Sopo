using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sopo.Repository;
using Sopo.Domain;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        User user1 = new User(){ 
            FirstName = "vaja", LastName = "Osepaishvili",
            Email = "email" 
        };
        User user2 = new User(){ 
            FirstName = "zura", LastName = "gogoladze",
            Email = "email" 
        };
        User user3 = new User(){ 
            FirstName = "tornike", LastName = "kvirkvelia",
            Email = "email" 
        };
        User user4 = new User(){ 
            FirstName = "dato", LastName = "Osepaishvili",
            Email = "email" 
        };

        List<User> list = new List<User>();
        list.Add(user1);
        list.Add(user3);
        List<User> list2 = new List<User>();
        list2.Add(user1);
        list2.Add(user3);
        list2.Add(user4);

        user2.Friend = list2;
        user4.Friend = list;
        using (var context = new SopoContext())
        {
            context.Users.Add(user1);
            context.Users.Add(user2);
            context.Users.Add(user3);
            context.Users.Add(user4);
            context.SaveChanges();
        }
    }
}