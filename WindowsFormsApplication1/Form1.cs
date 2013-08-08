using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Product[] list = new Product[20];
        private int current; //EnteredRecord
        private int index; //CurrentRecord

        public Form1()
        {
            InitializeComponent();
            current = 0;
            index = -1;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //service method
        private void Clear()
        {
            TxtID.Text = "";
            TxtDescription.Text = "";
            TxtMarkUp.Text = "";
            TxtCost.Text = "";
            TxtQty.Text = "";
            LblPrice.Text = "";
            TxtID.Enabled = true;
            TxtDescription.Enabled = true;
            TxtMarkUp.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (current == list.Length)
                MessageBox.Show("Product list is full - can\'t add any more stock");
            else
            {
                if (TxtID.Text == "" || TxtDescription.Text == "" || TxtMarkUp.Text == "")
                    MessageBox.Show("Please make sure the ID, Description and Mark Up Text Box are filled");
                else
                {
                    decimal markup;
                    if (decimal.TryParse(TxtMarkUp.Text, out markup) == false)
                        MessageBox.Show("Please checj the Mark Up Text Box value");
                    else
                    {
                        list[current] = new Product();
                        list[current].ID = TxtID.Text;
                        list[current].Description = TxtDescription.Text;
                        list[current].MarkUp = markup;
                        list[current].Cost = 0m;
                        list[current].Qty = 0;
                        index = current;
                        lstProduct.Items.Add(list[current].ToString());
                        current++;
                        Clear();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
                MessageBox.Show("Please select the product from the list first");
            else
            {
                for (int i = index; i < current; i++)
                    list[i] = list[i + 1];
                current--;
                lstProduct.Items.RemoveAt(index);
                Clear();
            }
        }

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lstProduct.SelectedIndex;
            if (index != -1) // found as -1 is false or NOT found
            {
                TxtID.Text = list[index].ID;
                TxtDescription.Text = list[index].Description;
                TxtMarkUp.Text = list[index].MarkUp.ToString();
                TxtQty.Text = list[index].Qty.ToString();
                TxtCost.Text = list[index].Cost.ToString();
                LblPrice.Text = list[index].SalePrice.ToString();
                TxtID.Enabled = false;
                TxtDescription.Enabled = false;
                TxtMarkUp.Enabled = false;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
                MessageBox.Show("Please the product from the list first");
            else
            {
                if (TxtCost.Text == "" || TxtQty.Text == "")
                    MessageBox.Show("Please make sure the QTY and COST Text Box are filled");
                else
                {
                    int qty;
                    if (int.TryParse(TxtQty.Text, out qty) == false || qty < 1)
                        MessageBox.Show("Please check the QTY value");
                    else
                    {
                        decimal cost;
                        if (decimal.TryParse(TxtCost.Text, out cost) == false || cost < 0M)
                            MessageBox.Show("Please check the COST value");
                        else
                        {
                            list[index].Qty += qty;
                            list[index].Cost = cost;
                            lstProduct.Items[index] = list[index].ToString();
                            MessageBox.Show("Stock is increased by " + qty.ToString());
                        }
                    }
                }
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
                MessageBox.Show("Please select the product from the list first");
            else
            {
                if (TxtQty.Text == "")
                    MessageBox.Show("Please make sure the QTY is filled");
                else
                {
                    int qty;
                    if (int.TryParse(TxtQty.Text, out qty) == false || qty < 0)
                        MessageBox.Show("Please check the QTY value");
                    else
                    {
                        if (qty > list[index].Qty)
                            MessageBox.Show("Please check the QTY value - It is higher than the current in stock");
                        else
                        {
                            list[index].Qty -= qty;
                            lstProduct.Items[index] = list[index].ToString();
                            //MessageBox.Show("Stock is reduced by " + qty.ToString());
                        }
                    }
                }
            }
            Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // setup Open File Dialog
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Select the file to OPEN";
            fd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = File.OpenText(fd.FileName);
                if (sr != null)
                {
                    // clear the list
                    lstProduct.Items.Clear();
                    current = 0;

                    string data = sr.ReadLine();
                    while (data != null)
                    {
                        string[] record = data.Split(','); // break the line into record details
                        list[current] = new Product(); // create new product
                        list[current].ID = record[0];
                        list[current].Description = record[1];
                        list[current].MarkUp = decimal.Parse(record[2]);
                        list[current].Cost = decimal.Parse(record[3]);
                        list[current].Qty = int.Parse(record[4]);
                        lstProduct.Items.Add(list[current].ToString());
                        current++;
                        data = sr.ReadLine();
                    }
                    sr.Close();
                    index = 0;
                }
                else
                    MessageBox.Show(" please check input file:");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current == 0) MessageBox.Show("There is no data to Save");
            else
            {
                SaveFileDialog fd = new SaveFileDialog();
                fd.Title = "Select the file to SAVE";
                fd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                fd.FileName = "Product.txt";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = File.CreateText(fd.FileName);
                    if (sw != null)
                    {
                        for (int i = 0; i < current; i++)
                            sw.WriteLine("{0},{1},{2},{3},{4}", list[i].ID, list[i].Description,
                            list[i].MarkUp, list[i].Cost, list[i].Qty);
                        sw.Close();
                        /* foreach(Product p in list)
                         * if (p != null)
                         * sw.WriteLine("{0},{1},{2},{3},{4}", p.ID, p.Description,
                            p.MarkUp, p.Cost, p.Qty);
                        */
                                                
                    }
                    else
                        MessageBox.Show("please check -- cannot create the output file");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (current == 0) MessageBox.Show("There is no data to Save");
            else
            {
                SaveFileDialog fd = new SaveFileDialog();
                fd.Title = "Select the file to SAVE";
                fd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                fd.FileName = "Product.txt";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = File.CreateText(fd.FileName);
                    if (sw != null)
                    {
                        for (int i = 0; i < current; i++)
                            sw.WriteLine("{0},{1},{2},{3},{4}", list[i].ID, list[i].Description,
                            list[i].MarkUp, list[i].Cost, list[i].Qty);
                        sw.Close();
                        /* foreach(Product p in list)
                         * if (p != null)
                         * sw.WriteLine("{0},{1},{2},{3},{4}", p.ID, p.Description,
                            p.MarkUp, p.Cost, p.Qty);
                        */

                    }
                    else
                        MessageBox.Show("please check -- cannot create the output file");
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            // setup Open File Dialog
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Select the file to OPEN";
            fd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = File.OpenText(fd.FileName);
                if (sr != null)
                {
                    // clear the list
                    lstProduct.Items.Clear();
                    current = 0;

                    string data = sr.ReadLine();
                    while (data != null)
                    {
                        string[] record = data.Split(','); // break the line into record details
                        list[current] = new Product(); // create new product
                        list[current].ID = record[0];
                        list[current].Description = record[1];
                        list[current].MarkUp = decimal.Parse(record[2]);
                        list[current].Cost = decimal.Parse(record[3]);
                        list[current].Qty = int.Parse(record[4]);
                        lstProduct.Items.Add(list[current].ToString());
                        current++;
                        data = sr.ReadLine();
                    }
                    sr.Close();
                    index = 0;
                }
                else
                    MessageBox.Show(" please check input file:");
            }
        }
    }
}
