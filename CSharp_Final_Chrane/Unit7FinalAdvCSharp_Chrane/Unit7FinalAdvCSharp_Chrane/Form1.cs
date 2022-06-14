using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalNamespace;
using IPetNamespace;
using DogNamespace;
using System.IO;

namespace Unit7FinalAdvCSharp_Chrane
{
    public partial class Form1 : Form
    {
        StreamReader inFile;
        StreamWriter outFile;
        private Dog aDog;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                
                string filename = "doginfo.txt";//reads data from a file
                inFile = new StreamReader(filename);
                string info;
                while ((info = inFile.ReadLine()) != null)//loop that reads whole file
                {

                    lbxDogs.Items.Add(info);//fills list box
                    
                }
                
            }
            catch(Exception exc)
            {
                MessageBox.Show("Exception occurred" + exc.Message);
            }
            inFile.Close();//closes file


        }

        private void btnAdopt_Click(object sender, EventArgs e)//Event
        {
            try
            {
                string info;
                info = lbxDogs.SelectedItem.ToString();
                lblOutput.Text = "Congratulations! You are a proud new dog owner of " + info;
                for (int i = lbxDogs.SelectedItems.Count - 1; i >= 0; i--)//loop
                {
                    lbxDogs.Items.Remove(lbxDogs.SelectedItems[i]);
                }
                outFile = new StreamWriter("doginfo.txt");//Saves Info for next user

                foreach (var item in lbxDogs.Items)//loop
                {
                    outFile.WriteLine(item.ToString());
                }
                outFile.Close();//clsoes file
            }
            catch(Exception exc)
            {
                MessageBox.Show("Exception occurred" + exc.Message);
            }
        }

        private void btnDonate_Click(object sender, EventArgs e)//Event
        {
            try
            {
                if(tbxName.Text == ""||tbxColor.Text == ""||tbxBreed.Text == "")//input validation
                {
                    lblOutput.Text = "Please fill in the text boxes!";               
                }
                if (tbxName.Text == "" && tbxColor.Text == "" && tbxBreed.Text == "")//input validation
                {
                    lblOutput.Text = "Please fill in the text boxes!";
                }
                else
                {
                    string name, breed, color, info;
                    double price = 100.0;
                    name = tbxName.Text;
                    breed = tbxBreed.Text;
                    color = tbxColor.Text;
                    aDog = new Dog(name, "Fur", 4, breed, color);//Builds dog object referencing .dll files
                    info = "Name: " + aDog.Name + " Breed: " + aDog.Breed + " Color: " + aDog.Color;
                    info = info + " Price: " + price.ToString();
                    lbxDogs.Items.Add(info);
                    outFile = new StreamWriter("doginfo.txt");//Saves info for next user

                    foreach (var item in lbxDogs.Items)//loop
                    {
                        outFile.WriteLine(item.ToString());
                    }
                    outFile.Close();//closes 
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Exception occurred" + exc.Message);
            }
        }
    }
}
