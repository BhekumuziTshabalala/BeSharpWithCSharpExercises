namespace Chapter3;

static class Program
{
   
    static void Main()
    {
        // Form f = new Form();
        //
        // f.Size = new Size(1000, 600);
        // f.BackColor = Color.Green;
        // f.Text = "Its a new form";
        // f.StartPosition = FormStartPosition.CenterScreen;
        //
        // Application.Run( f);
        
        GetName name = new GetName();
        name.Name = "Get Name";
        
        Application.Run(new Exercise1());
        
    }
}