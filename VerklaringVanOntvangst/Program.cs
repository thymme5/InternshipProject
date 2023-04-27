namespace VerklaringVanOntvangst
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            catch (Exception)
            {
                MessageBox.Show("Error 5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}