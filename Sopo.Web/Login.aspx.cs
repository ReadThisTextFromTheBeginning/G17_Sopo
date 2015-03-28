using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sopo.Domain;
using Sopo.Core;
using Sopo.Core.Services;
using Sopo.Domain.Interfaces;
using Sopo.Repository;


public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnLogin_Click(object sender, EventArgs e) {
        User user = new User();

        //IRepository<User> = Unity.Resolve<IRepository>();
        //IUnitOfWork<User> = Unity.Resolve<IRepository>();

        UserService service = new UserService(new UnitOfWork<User>(user), new UserRepository()); //aq ukve mwirdeba unity resolver-i
      var userProfile =  service.Login(user.Username, user.Password);
      if (userProfile == null)
      {
          //some warning banner should activate
      }
      else
      {
          Response.Redirect("UserProfile.aspx");
      }
    }
    
                                                                  

    protected void BtnRegister_Click(object sender, EventArgs e) {
        Response.Redirect("Register.aspx");
    }
}