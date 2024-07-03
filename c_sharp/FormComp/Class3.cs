using System;

namespace FormComp
{
	internal class Basisklasse : Button
	{
		Basisklasse button = new Button();

		internal Basisklasse()
		{
		}
		public virtual void klicken() 
		{ 
		}
	}

	internal class AnzeigeButton : Basisklasse 
	{
        public override void klicken()
        {
            textBox1.Text = (string)listBox1.SelectedItem;
        }
    }

	internal class HinzufuegenButton : Basisklasse 
	{
        public override void klicken()
        {
            listBox1.Items.Add(listBox1.Text);
        }
    }

	internal class EntfernenButton : Basisklasse 
	{
        public override void klicken()
        {
            listBox1.Items.Remove(textBox1.Text);
        }
    }
}