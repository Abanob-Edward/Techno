using Appliaction.Services;
using Context;
using Infrastructure.Repositores;
using Model.Models;
using Presentation.User_Role;


namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
    
       
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();



            Application.Run(new LoginAndRegister());
            //Application.Run(new CartItemPanel());
            // Application.Run(new UserPanel());
            
            //  Application.Run(new UserPanel());
           // Application.Run(new AdminPanal());
            //Application.Run(new tsetpigin());
            //Application.Run(new userProfielPanel());
        }
    }
}