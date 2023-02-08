using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameSearchDemo
{
    public partial class Form1 : Form
    {
        List<Names> NameList = new List<Names>();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadNamesButton_Click(object sender, EventArgs e)
        {
            NameList.Clear();
            try
            {
                using (StreamReader loadNameStream = new StreamReader("Names.csv"))
                {
                    string eachLine;
                    if (!loadNameStream.EndOfStream)
                    {
                        eachLine = loadNameStream.ReadLine();
                        MessageBox.Show("Loading " + eachLine);
                    }
                    while (!loadNameStream.EndOfStream)
                    {
                        eachLine = loadNameStream.ReadLine();
                        string[] eachNameFields = eachLine.Split(',');
                        string firstName = eachNameFields[0];
                        string lastName = eachNameFields[1];
                        Names eachName = new Names(firstName, lastName);
                        NameList.Add(eachName);
                    }
                }
                LoadNamesToListBox();
                MessageBox.Show("Loaded " + NameList.Count + " names from file.");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadNamesToListBox()
        {
            NamesListBox.Items.Clear();
            NamesListBox.Items.Add(String.Format("{0,-15}{1,-15}", "Last_Name", "First_Name"));
            foreach (Names name in NameList) {
                NamesListBox.Items.Add(name);
            }
        }

        private void SaveNameButton_Click(object sender, EventArgs e)
        {
            //sorted the name first by last name
            List<Names> SortedNameBasedOnLastName = NameList.OrderBy(name => name.LastName).ToList();
            SortedNameBasedOnLastName = (from name in NameList
                                         orderby name.LastName
                                         select name).ToList();

            try
            {
                using (StreamWriter saveNameStream = new StreamWriter("Update-Names.csv"))
                {
                    string headerLine = "Last_Name,First_Name";
                    saveNameStream.WriteLine(headerLine);
                    foreach (Names names in SortedNameBasedOnLastName)
                    {
                        string nameItem = names.LastName + "," + names.FirstName;
                        saveNameStream.WriteLine(nameItem);
                    }
                }
                MessageBox.Show("Saved " + SortedNameBasedOnLastName.Count + " records into the output file");
                SortedNameBasedOnLastName.Clear();
                NamesListBox.Items.Clear();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<Names> SearchedName = NameList.OrderBy(name => name.LastName).ToList();
            SearchedName = (from name in NameList
                            orderby name.LastName
                            where name.FirstName.Contains(SearchNameTextBox.Text) || name.LastName.Contains(SearchNameTextBox.Text)
                            select name).ToList();

            if (SearchedName.Count > 0)
            {
                NamesListBox.Items.Clear();
                MessageBox.Show(SearchNameTextBox.Text + " is present in the list");
                NamesListBox.Items.Add(string.Format("{0,-15}{1,-15}", "Last_Name", "First_Name"));
                foreach(Names name in SearchedName)
                {
                    NamesListBox.Items.Add(name);
                }
            }
            else
            {
                MessageBox.Show(SearchNameTextBox.Text + " is not present in the list");
            }

        }

        private void NamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lbIndex = NamesListBox.SelectedIndex;
            if (lbIndex > -1) //when listbox is cleared, any current SelectedIndex goes back to -1
            {
                if (lbIndex == 0)
                {
                    MessageBox.Show("You have selected header line");
                }
                else if (NameList.Count > 0)
                {
                    // MessageBox.Show("Selected User Name is "
                    //                 + UserList[lbIndex - 1].UserName);
                    OutputLabel.Text = "You have selected " + NameList[lbIndex - 1].FirstName;

                }
            }
        }
    }
}
