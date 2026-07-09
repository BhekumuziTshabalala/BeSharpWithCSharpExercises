namespace Chapter3;

public class Exercise1:Form
{
    public Exercise1()
    {
        this.Name = "Names";
        this.StartPosition = FormStartPosition.CenterParent;
        
        
        // title 
        Label lblTitle = new Label();
        lblTitle.Text = "Title";
        lblTitle.Left = lblTitle.Top = 10;
        this.Controls.Add(lblTitle);
        
        ComboBox cbName = new ComboBox();
        cbName.Items.AddRange( "Mr", "Dr", "Ms", "Mrs", "Miss" );
        cbName.Top = lblTitle.Top + lblTitle.Height;
        cbName.Left = lblTitle.Left;
        this.Controls.Add(cbName);
        
        // First Nmae
        Label lblName = new Label();
        lblName.Text = "First name";
        lblName.Top = lblTitle.Top + lblTitle.Height + 40;
        lblName.Left = lblTitle.Left;
        this.Controls.Add(lblName);
        
        TextBox tbName = new TextBox();
        tbName.Top = lblName.Top + lblName.Height ;
        tbName.Left = lblName.Left;
        this.Controls.Add(tbName);
        
        // First Nmae
        Label lblSurname = new Label();
        lblSurname.Text = "Surname";
        lblSurname.Top = tbName.Top + tbName.Height ;
        lblSurname.Left = tbName.Left;
        this.Controls.Add(lblSurname);
        
        TextBox tblSurname = new TextBox();
        tblSurname.Top = lblSurname.Top + lblSurname.Height ;
        tblSurname.Left = lblSurname.Left;
        this.Controls.Add(tblSurname);
        
        Button btnGreetings = new Button();
        btnGreetings.Text = "&Greetings";
        btnGreetings.Top = lblSurname.Top + lblSurname.Height + 40;
        btnGreetings.Left = lblSurname.Left;
        this.Controls.Add(btnGreetings);
        
        btnGreetings.Click += (sender, e) => 
        {
            // Double-check 'tblSurname' - it might be a typo for 'tbSurname' based on your 'tbName' convention!
            MessageBox.Show($"Hello {cbName.Text} {tbName.Text} {tblSurname.Text}");  
        };






    }
}