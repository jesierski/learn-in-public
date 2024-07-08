public class ButtonBase : Button
{
    public ButtonBase()
    {
        this.Size = new System.Drawing.Size(100, 30);
    }
}

public class NachrichtButton : ButtonBase
{
    public NachrichtButton()
    {
        this.Click += (sender, e) => Console.WriteLine("Hallo Welt!");
    }
}

public class SchliessButton : ButtonBase
{
    public SchliessButton()
    {
        this.Click += (sender, e) => Application.Exit();
    }
}
