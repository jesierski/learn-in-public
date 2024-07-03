using System;

namespace FormComp 
{
    internal class KlasseListBox
    {
        ListBox listbox = new ListBox();

        internal KlasseListBox()
        {
        }

        internal void Hinzufuegen(string item) 
        {
            listbox.Items.Add(item);
        }

        internal void Entfernen(string item) 
        { 
            listbox.Items.Remove(item);
        }

        internal string Abrufen() 
        {
            string item = (string)listBox1.SelectedItem;
            return item;
        }
    }
}
