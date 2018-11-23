/*
FILE:          TriangleForm.cs
PROJECT:       INFO2180 Assignment 2
PROGRAMMER:    Julien Malenfant
FIRST VERSION: 20/11/2018
DESCRIPTION:   Holds form functionality
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleCalculator
{
    public partial class TriangleForm : Form
    {
        public TriangleForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// If I delete this, it yells at me - tried for a while and didn't want to keep wasting time.
        /// Please disregard the method.
        /// </summary>
        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Takes user textbox side input to calculate the hypotenuse of a right triangle
        /// </summary>
        private void calcRightTriBtn_Click(object sender, EventArgs e)
        {
            Triangle tri = new Triangle();
            double area = 0;
            double hyp = 0;
            double side1 = 0;
            double side2 = 0;

            //Convert input to double and perform some input level validation (not null, is a double)
            try {
                side1 = Double.Parse(side1Box.Text);
            }
            catch (Exception ex)
            {
                errRightTriLbl.Text = ex.Message;
                return;
            }

            try
            {
                side2 = Double.Parse(side2Box.Text);
            }
            catch (Exception ex)
            {
                errRightTriLbl.Text = ex.Message;
                return;
            }

            //Calculate and report results
            area = tri.calcAreaOfRightTri(side1, side2);
            hyp = tri.calcHypOfRightTri(side1, side2);

            hypBox.Text = hyp.ToString();
            areaBox.Text = area.ToString();
        }

        /// <summary>
        /// Takes user textbox angle input to calculate the third angle of a triangle
        /// </summary>
        private void calcAngleBtn_Click(object sender, EventArgs e)
        {
            Triangle tri = new Triangle();

            int angle1 = 0;
            int angle2 = 0;
            int angle3 = 0;

            //Convert input to double and perform some input level validation (not null, is a double)
            try
            {
                angle1 = Int32.Parse(angle1Box.Text);
            }
            catch (Exception ex)
            {
                errAngleLbl.Text = ex.Message;
                return;
            }

            try
            {
                angle2 = Int32.Parse(angle2Box.Text);
            }
            catch (Exception ex)
            {
                errAngleLbl.Text = ex.Message;
                return;
            }

            //Calculate and report results
            angle3 = tri.calcAngleOfTri(angle1, angle2);
            angleResultbox.Text = angle3.ToString();
        }

        /// <summary>
        /// If I delete this, it yells at me - tried for a while and didn't want to keep wasting time.
        /// Please disregard the method.
        /// </summary>
        private void errRightTriLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
