namespace _11_Entity_DBFirst
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
            Application.Run(new Frm_View());
            //
            // string que genera el scafflod-dbContext
            // scaffold-dbcontext -Context CoderContext -OutputDir Models -ContextDir Database "server=localhost;Database=Coder_Clase11_Entity;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer
        }
    }
}