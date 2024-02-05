using System;
using System.Windows.Forms;
using Appliaction.Services;
using Context;
using Infrastructure.Repositores;
using Model.Models;

namespace Presentation.User_Role
{
    public partial class userProfielPanel : Form
    {
        private readonly IUserService userService;
        public int? UserCurrentID;

       
        public userProfielPanel(int? userCurrenID)
        {
            UserCurrentID = userCurrenID;
            InitializeComponent();
            userService = new UserService(new UserRepository(new _Context()));
        }

        private void userProfielPanel_Load(object sender, EventArgs e)
        {
            try
            {
                if (UserName != null && Emial != null && Mobile != null && UserN != null)
                {
                    User user = userService.GetUserbyID(UserCurrentID.Value);
                    UserName.Text = user?.FirstName + " " + user?.LastName;
                    Emial.Text = user?.Email;
                    Mobile.Text = user?.PhoneNumber != null ? user.PhoneNumber.ToString() : string.Empty;
                    UserN.Text = user?.UserName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


   

       
    }
}