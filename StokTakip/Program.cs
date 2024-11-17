namespace StokTakip
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
            FrmGiris girisFormu = new FrmGiris();
            if (girisFormu.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }
    }
}