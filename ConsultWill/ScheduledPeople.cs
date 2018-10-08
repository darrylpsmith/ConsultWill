﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ConsultWill
{
    public partial class ScheduledPeople : UserControl
    {


        public delegate void SelectedPersonChanged(string Person);
        public event SelectedPersonChanged selectedPersonChanged;


        private string _selectedMenuItem;
        ListViewItem selItm;
        private readonly ContextMenuStrip collectionRoundMenuStrip;


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            if (File.Exists(StaticFunctions.GetSelectedPatientCommentFolder(_selectedMenuItem) + "\\commemts.txt") == true)
            {
                File.ReadAllText(StaticFunctions.GetSelectedPatientCommentFolder(_selectedMenuItem) + "\\commemts.txt");
                string comm = File.ReadAllText (StaticFunctions.GetSelectedPatientCommentFolder(_selectedMenuItem) + "\\commemts.txt");
                MessageBox.Show(comm, "Comments");
            }
            else
            {
                MessageBox.Show("No comments for this patient.");
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            string existingComm = "";
            if (File.Exists(StaticFunctions.GetSelectedPatientCommentFolder(_selectedMenuItem) + "\\commemts.txt") == true)
            {
                File.ReadAllText(StaticFunctions.GetSelectedPatientCommentFolder(_selectedMenuItem) + "\\commemts.txt");
                existingComm = File.ReadAllText(StaticFunctions.GetSelectedPatientCommentFolder(_selectedMenuItem) + "\\commemts.txt");
            }


            Comments cm = new Comments();
            cm.Comment = existingComm;
            cm.ShowDialog();
            string comm = cm.Comment;


            if (cm.DialogResult == DialogResult.OK)
            {
                cm = null;

                if (Directory.Exists(StaticFunctions.GetSelectedPatientCommentFolder(_selectedMenuItem.ToString())) == false)
                {
                    Directory.CreateDirectory(StaticFunctions.GetSelectedPatientCommentFolder(_selectedMenuItem));
                }

                File.WriteAllText(StaticFunctions.GetSelectedPatientCommentFolder(_selectedMenuItem) + "\\commemts.txt", comm);
                selItm.ForeColor = Color.Red;
            }

        }

        private void myListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            Point p = lvwTodaysPatients.PointToClient(new Point(e.X, e.Y));

            selItm = lvwTodaysPatients.GetItemAt(e.X, e.Y);

            if (selItm != null)
            {
                int index = selItm.Index;
                int x, y;

                //Point localPoint = lvwTodaysPatients.PointToClient(new Point(x, y));

                //int index =  lvwTodaysPatients.GetItemAt(localPoint.X, localPoint.Y).Index;

                if (index >= 0)
                {
                    _selectedMenuItem = lvwTodaysPatients.Items[index].SubItems[0].Text;
                    collectionRoundMenuStrip.Show(Cursor.Position);
                    collectionRoundMenuStrip.Visible = true;
                }
                else
                {
                    collectionRoundMenuStrip.Visible = false;
                }
            }
        }
        public ScheduledPeople()
        {
            InitializeComponent();
            LoadTodaysPatients();
            lvwTodaysPatients.View = View.Details;

            var toolStripMenuItem1 = new ToolStripMenuItem { Text = "Add Comments" };
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            var toolStripMenuItem2 = new ToolStripMenuItem { Text = "View Comments" };
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            collectionRoundMenuStrip = new ContextMenuStrip();
            collectionRoundMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            lvwTodaysPatients.MouseDown += myListBox_MouseDown;
        }

        public void Refresh()
        {
            try
            {
                if (StaticFunctions.UserMode == UserMode.Doctor)
                {
                    LoadTodaysPatients();
                }
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }



        public void AddToToday (string Person)
        {
            string[] pat = new string[] { Person, DateTime.UtcNow.ToString() };
            var itm = new ListViewItem(pat);
            StaticFunctions.AddPatientToTodaysConsults(Person);
            lvwTodaysPatients.Items.Add(itm);
        }


        private void LoadTodaysPatients()
        {
            lvwTodaysPatients.Items.Clear();
            foreach (var patient in StaticFunctions.GetTodaysConsults())
            {

                string[] pat = new string[] { patient, DateTime.UtcNow.ToString() };
                var itm = new ListViewItem(pat);
                lvwTodaysPatients.Items.Add(itm);
                
                if (File.Exists(StaticFunctions.GetSelectedPatientCommentFolder(patient) + "\\commemts.txt") == true)
                {
                    itm.ForeColor = Color.Red;
                }


            }
        }

        private void lvwTodaysPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwTodaysPatients.SelectedItems.Count > 0)
                {
                    selectedPersonChanged(lvwTodaysPatients.SelectedItems[0].Text);

                    
                    //'TODO'
                    //txtFindPatient_TextChanged(this, null);
                }

            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }


        private void btnClearTodaysConsults_Click(object sender, EventArgs e)
        {
            try
            {
                StaticFunctions.ClearTodaysPatients();
                lvwTodaysPatients.Items.Clear();
            }
            catch (Exception ex)
            {
                StaticFunctions.HandleException(ex);
            }
        }

        private void ScheduledPeople_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadTodaysPatients();
        }
    }
}
