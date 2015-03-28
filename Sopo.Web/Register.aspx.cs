using Sopo.Core;
using Sopo.Core.Services;
using Sopo.Domain;
using Sopo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnRegister_Click(object sender, EventArgs e)
    {
        User userProfile = new User();

        UserService service = new UserService(new UnitOfWork<User>(userProfile), new UserRepository());

        var u = service.Register(userProfile);
    }
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}