namespace Chapter3;

public class GetName : Form
{
    public GetName()
    {
        
        // label
        Label lblName = new Label();
        lblName.Text = "Type your name here";
        lblName.AutoSize = true;
        lblName.Left = lblName.Top = 8;
        this.Controls.Add(lblName);
        
        // Text Box
        TextBox tbName = new TextBox();
        tbName.Left = 8;
        tbName.Top = lblName.Top + lblName.Height;
        this.Controls.Add(tbName);
        
        Button btnNamMessage = new Button();
        btnNamMessage.Text = "&Message";
        btnNamMessage.Left = 8;
        btnNamMessage.Top = lblName.Top + lblName.Height + 20;
        this.Controls.Add(btnNamMessage);
        
        Button btnNameCancel = new Button();
        btnNameCancel.Text = "&Cancel";
        btnNameCancel.Left = btnNameCancel.Left + btnNameCancel.Width + 8;
        btnNameCancel.Top = lblName.Top + lblName.Height + 20;
        this.Controls.Add(btnNameCancel);
        

    }
    
    
   
}