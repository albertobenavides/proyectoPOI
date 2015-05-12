using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Timbiriche
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //private List<Microsoft.VisualBasic.PowerPacks.OvalShape> circulosLista;
        //Microsoft.VisualBasic.PowerPacks.OvalShape[] ovalArr;
        //int numeroPuntos;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void generador(int x, int y, int c) {

                System.Windows.Forms.Button newbutton = new System.Windows.Forms.Button();
                
                newbutton.Height = 31;
                newbutton.Width = 31;
                newbutton.ForeColor = Color.Black;
                newbutton.BackColor = Color.DarkRed;
                newbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                newbutton.Location = new Point(x, y);
                newbutton.FlatAppearance.BorderSize = 3;
                newbutton.Enabled = false;
                if (c == 1) {
                    newbutton.BackColor = Color.Red;
                }
                if (c == 2)
                {
                    newbutton.BackColor = Color.Green;

                }
                if (c == 3)
                {
                    newbutton.BackColor = Color.Blue;

                }
                this.Controls.Add(newbutton);
            
        }

        private void InitializeComponent()
        {
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape9 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape8 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape7 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape6 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape5 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape37 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape36 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape35 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape34 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape33 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape32 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape31 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape30 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape29 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape28 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape27 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape26 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape25 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape24 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape23 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape22 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape21 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape20 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape19 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape18 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape17 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape10 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape16 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape15 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape14 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape13 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.asd = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape4 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape3 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lineShape55 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape51 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape47 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape46 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape45 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape44 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape43 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape42 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape41 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape40 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape39 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape38 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape37 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape36 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape35 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape34 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape33 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape32 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape31 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape30 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape29 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape28 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape27 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape26 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape25 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape24 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape23 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape22 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape21 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape20 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape19 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape18 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape17 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape16 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape15 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape14 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape13 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape12 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape11 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape10 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape9 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape60 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape59 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape58 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape57 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape56 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape54 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape53 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape52 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape50 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape49 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape48 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape9,
            this.ovalShape8,
            this.ovalShape7,
            this.ovalShape6,
            this.ovalShape5,
            this.ovalShape37,
            this.ovalShape36,
            this.ovalShape35,
            this.ovalShape34,
            this.ovalShape33,
            this.ovalShape32,
            this.ovalShape31,
            this.ovalShape30,
            this.ovalShape29,
            this.ovalShape28,
            this.ovalShape27,
            this.ovalShape26,
            this.ovalShape25,
            this.ovalShape24,
            this.ovalShape23,
            this.ovalShape22,
            this.ovalShape21,
            this.ovalShape20,
            this.ovalShape19,
            this.ovalShape18,
            this.ovalShape17,
            this.ovalShape10,
            this.ovalShape16,
            this.ovalShape15,
            this.ovalShape14,
            this.ovalShape13,
            this.asd,
            this.ovalShape4,
            this.ovalShape3,
            this.ovalShape2,
            this.ovalShape1,
            this.lineShape55,
            this.lineShape51,
            this.lineShape47,
            this.lineShape46,
            this.lineShape45,
            this.lineShape44,
            this.lineShape43,
            this.lineShape42,
            this.lineShape41,
            this.lineShape40,
            this.lineShape39,
            this.lineShape38,
            this.lineShape37,
            this.lineShape36,
            this.lineShape35,
            this.lineShape34,
            this.lineShape33,
            this.lineShape32,
            this.lineShape31,
            this.lineShape30,
            this.lineShape29,
            this.lineShape28,
            this.lineShape27,
            this.lineShape26,
            this.lineShape25,
            this.lineShape24,
            this.lineShape23,
            this.lineShape22,
            this.lineShape21,
            this.lineShape20,
            this.lineShape19,
            this.lineShape18,
            this.lineShape17,
            this.lineShape16,
            this.lineShape15,
            this.lineShape14,
            this.lineShape13,
            this.lineShape8,
            this.lineShape12,
            this.lineShape11,
            this.lineShape10,
            this.lineShape9,
            this.lineShape7,
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1,
            this.lineShape60,
            this.lineShape59,
            this.lineShape58,
            this.lineShape57,
            this.lineShape56,
            this.lineShape54,
            this.lineShape53,
            this.lineShape52,
            this.lineShape50,
            this.lineShape49,
            this.lineShape48});
            this.shapeContainer1.Size = new System.Drawing.Size(306, 200);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape9
            // 
            this.ovalShape9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape9.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape9.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape9.Location = new System.Drawing.Point(140, 170);
            this.ovalShape9.Name = "ovalShape9";
            this.ovalShape9.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape8
            // 
            this.ovalShape8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape8.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape8.Location = new System.Drawing.Point(110, 170);
            this.ovalShape8.Name = "ovalShape8";
            this.ovalShape8.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape7
            // 
            this.ovalShape7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape7.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape7.Location = new System.Drawing.Point(20, 170);
            this.ovalShape7.Name = "ovalShape7";
            this.ovalShape7.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape6
            // 
            this.ovalShape6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape6.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape6.Location = new System.Drawing.Point(170, 170);
            this.ovalShape6.Name = "ovalShape6";
            this.ovalShape6.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape5
            // 
            this.ovalShape5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape5.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape5.Location = new System.Drawing.Point(80, 170);
            this.ovalShape5.Name = "ovalShape5";
            this.ovalShape5.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape37
            // 
            this.ovalShape37.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape37.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape37.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape37.Location = new System.Drawing.Point(80, 140);
            this.ovalShape37.Name = "ovalShape18";
            this.ovalShape37.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape36
            // 
            this.ovalShape36.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape36.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape36.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape36.Location = new System.Drawing.Point(170, 140);
            this.ovalShape36.Name = "ovalShape15";
            this.ovalShape36.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape35
            // 
            this.ovalShape35.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape35.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape35.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape35.Location = new System.Drawing.Point(20, 140);
            this.ovalShape35.Name = "ovalShape19";
            this.ovalShape35.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape34
            // 
            this.ovalShape34.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape34.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape34.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape34.Location = new System.Drawing.Point(110, 140);
            this.ovalShape34.Name = "ovalShape17";
            this.ovalShape34.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape33
            // 
            this.ovalShape33.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape33.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape33.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape33.Location = new System.Drawing.Point(140, 140);
            this.ovalShape33.Name = "ovalShape16";
            this.ovalShape33.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape32
            // 
            this.ovalShape32.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape32.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape32.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape32.Location = new System.Drawing.Point(50, 140);
            this.ovalShape32.Name = "ovalShape14";
            this.ovalShape32.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape31
            // 
            this.ovalShape31.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape31.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape31.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape31.Location = new System.Drawing.Point(170, 110);
            this.ovalShape31.Name = "ovalShape15";
            this.ovalShape31.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape30
            // 
            this.ovalShape30.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape30.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape30.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape30.Location = new System.Drawing.Point(20, 110);
            this.ovalShape30.Name = "ovalShape19";
            this.ovalShape30.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape29
            // 
            this.ovalShape29.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape29.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape29.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape29.Location = new System.Drawing.Point(80, 110);
            this.ovalShape29.Name = "ovalShape18";
            this.ovalShape29.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape28
            // 
            this.ovalShape28.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape28.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape28.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape28.Location = new System.Drawing.Point(110, 110);
            this.ovalShape28.Name = "ovalShape17";
            this.ovalShape28.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape27
            // 
            this.ovalShape27.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape27.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape27.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape27.Location = new System.Drawing.Point(140, 110);
            this.ovalShape27.Name = "ovalShape16";
            this.ovalShape27.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape26
            // 
            this.ovalShape26.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape26.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape26.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape26.Location = new System.Drawing.Point(50, 110);
            this.ovalShape26.Name = "ovalShape14";
            this.ovalShape26.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape25
            // 
            this.ovalShape25.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape25.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape25.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape25.Location = new System.Drawing.Point(140, 80);
            this.ovalShape25.Name = "ovalShape13";
            this.ovalShape25.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape24
            // 
            this.ovalShape24.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape24.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape24.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape24.Location = new System.Drawing.Point(170, 80);
            this.ovalShape24.Name = "ovalShape12";
            this.ovalShape24.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape23
            // 
            this.ovalShape23.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape23.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape23.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape23.Location = new System.Drawing.Point(110, 80);
            this.ovalShape23.Name = "ovalShape4";
            this.ovalShape23.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape22
            // 
            this.ovalShape22.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape22.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape22.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape22.Location = new System.Drawing.Point(80, 80);
            this.ovalShape22.Name = "ovalShape3";
            this.ovalShape22.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape21
            // 
            this.ovalShape21.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape21.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape21.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape21.Location = new System.Drawing.Point(50, 80);
            this.ovalShape21.Name = "ovalShape2";
            this.ovalShape21.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape20
            // 
            this.ovalShape20.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape20.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape20.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape20.Location = new System.Drawing.Point(20, 80);
            this.ovalShape20.Name = "ovalShape1";
            this.ovalShape20.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape19
            // 
            this.ovalShape19.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape19.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape19.Location = new System.Drawing.Point(20, 50);
            this.ovalShape19.Name = "ovalShape19";
            this.ovalShape19.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape18
            // 
            this.ovalShape18.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape18.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape18.Location = new System.Drawing.Point(80, 50);
            this.ovalShape18.Name = "ovalShape18";
            this.ovalShape18.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape17
            // 
            this.ovalShape17.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape17.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape17.Location = new System.Drawing.Point(110, 50);
            this.ovalShape17.Name = "ovalShape17";
            this.ovalShape17.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape10
            // 
            this.ovalShape10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape10.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape10.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovalShape10.Location = new System.Drawing.Point(50, 170);
            this.ovalShape10.Name = "ovalShape10";
            this.ovalShape10.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape16
            // 
            this.ovalShape16.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape16.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape16.Location = new System.Drawing.Point(140, 50);
            this.ovalShape16.Name = "ovalShape16";
            this.ovalShape16.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape15
            // 
            this.ovalShape15.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape15.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape15.Location = new System.Drawing.Point(170, 50);
            this.ovalShape15.Name = "ovalShape15";
            this.ovalShape15.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape14
            // 
            this.ovalShape14.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape14.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape14.Location = new System.Drawing.Point(50, 50);
            this.ovalShape14.Name = "ovalShape14";
            this.ovalShape14.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape13
            // 
            this.ovalShape13.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape13.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape13.Location = new System.Drawing.Point(140, 20);
            this.ovalShape13.Name = "ovalShape13";
            this.ovalShape13.Size = new System.Drawing.Size(8, 8);
            // 
            // asd
            // 
            this.asd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.asd.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.asd.Location = new System.Drawing.Point(170, 20);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape4
            // 
            this.ovalShape4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape4.Location = new System.Drawing.Point(110, 20);
            this.ovalShape4.Name = "ovalShape4";
            this.ovalShape4.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape3
            // 
            this.ovalShape3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape3.Location = new System.Drawing.Point(80, 20);
            this.ovalShape3.Name = "ovalShape3";
            this.ovalShape3.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape2
            // 
            this.ovalShape2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape2.Location = new System.Drawing.Point(50, 20);
            this.ovalShape2.Name = "ovalShape2";
            this.ovalShape2.Size = new System.Drawing.Size(8, 8);
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ovalShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape1.Location = new System.Drawing.Point(20, 20);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(8, 8);
            // 
            // lineShape55
            // 
            this.lineShape55.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape55.BorderWidth = 4;
            this.lineShape55.Name = "lineShape55";
            this.lineShape55.X1 = 54;
            this.lineShape55.X2 = 84;
            this.lineShape55.Y1 = 144;
            this.lineShape55.Y2 = 144;
            this.lineShape55.Click += new System.EventHandler(this.lineShape55_Click);
            this.lineShape55.MouseEnter += new System.EventHandler(this.lineShape55_MouseEnter);
            this.lineShape55.MouseLeave += new System.EventHandler(this.lineShape55_MouseLeave);
            // 
            // lineShape51
            // 
            this.lineShape51.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape51.BorderWidth = 4;
            this.lineShape51.Name = "lineShape51";
            this.lineShape51.X1 = 24;
            this.lineShape51.X2 = 54;
            this.lineShape51.Y1 = 144;
            this.lineShape51.Y2 = 144;
            this.lineShape51.Click += new System.EventHandler(this.lineShape51_Click);
            this.lineShape51.MouseEnter += new System.EventHandler(this.lineShape51_MouseEnter);
            this.lineShape51.MouseLeave += new System.EventHandler(this.lineShape51_MouseLeave);
            // 
            // lineShape47
            // 
            this.lineShape47.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape47.BorderWidth = 4;
            this.lineShape47.Name = "lineShape47";
            this.lineShape47.X1 = 144;
            this.lineShape47.X2 = 174;
            this.lineShape47.Y1 = 144;
            this.lineShape47.Y2 = 144;
            this.lineShape47.Click += new System.EventHandler(this.lineShape47_Click);
            this.lineShape47.MouseEnter += new System.EventHandler(this.lineShape47_MouseEnter);
            this.lineShape47.MouseLeave += new System.EventHandler(this.lineShape47_MouseLeave);
            // 
            // lineShape46
            // 
            this.lineShape46.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape46.BorderWidth = 4;
            this.lineShape46.Name = "lineShape46";
            this.lineShape46.X1 = 84;
            this.lineShape46.X2 = 114;
            this.lineShape46.Y1 = 144;
            this.lineShape46.Y2 = 144;
            this.lineShape46.Click += new System.EventHandler(this.lineShape46_Click);
            this.lineShape46.MouseEnter += new System.EventHandler(this.lineShape46_MouseEnter);
            this.lineShape46.MouseLeave += new System.EventHandler(this.lineShape46_MouseLeave);
            // 
            // lineShape45
            // 
            this.lineShape45.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape45.BorderWidth = 4;
            this.lineShape45.Name = "lineShape45";
            this.lineShape45.X1 = 114;
            this.lineShape45.X2 = 144;
            this.lineShape45.Y1 = 144;
            this.lineShape45.Y2 = 144;
            this.lineShape45.Click += new System.EventHandler(this.lineShape45_Click);
            this.lineShape45.MouseEnter += new System.EventHandler(this.lineShape45_MouseEnter);
            this.lineShape45.MouseLeave += new System.EventHandler(this.lineShape45_MouseLeave);
            // 
            // lineShape44
            // 
            this.lineShape44.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape44.BorderWidth = 4;
            this.lineShape44.Name = "lineShape44";
            this.lineShape44.X1 = 54;
            this.lineShape44.X2 = 84;
            this.lineShape44.Y1 = 114;
            this.lineShape44.Y2 = 114;
            this.lineShape44.Click += new System.EventHandler(this.lineShape44_Click);
            this.lineShape44.MouseEnter += new System.EventHandler(this.lineShape44_MouseEnter);
            this.lineShape44.MouseLeave += new System.EventHandler(this.lineShape44_MouseLeave);
            // 
            // lineShape43
            // 
            this.lineShape43.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape43.BorderWidth = 4;
            this.lineShape43.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape43.Name = "lineShape43";
            this.lineShape43.X1 = 84;
            this.lineShape43.X2 = 84;
            this.lineShape43.Y1 = 114;
            this.lineShape43.Y2 = 144;
            this.lineShape43.Click += new System.EventHandler(this.lineShape43_Click);
            this.lineShape43.MouseEnter += new System.EventHandler(this.lineShape43_MouseEnter);
            this.lineShape43.MouseLeave += new System.EventHandler(this.lineShape43_MouseLeave);
            // 
            // lineShape42
            // 
            this.lineShape42.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape42.BorderWidth = 4;
            this.lineShape42.Name = "lineShape42";
            this.lineShape42.X1 = 54;
            this.lineShape42.X2 = 54;
            this.lineShape42.Y1 = 114;
            this.lineShape42.Y2 = 144;
            this.lineShape42.Click += new System.EventHandler(this.lineShape42_Click);
            this.lineShape42.MouseEnter += new System.EventHandler(this.lineShape42_MouseEnter);
            this.lineShape42.MouseLeave += new System.EventHandler(this.lineShape42_MouseLeave);
            // 
            // lineShape41
            // 
            this.lineShape41.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape41.BorderWidth = 4;
            this.lineShape41.Name = "lineShape41";
            this.lineShape41.X1 = 24;
            this.lineShape41.X2 = 24;
            this.lineShape41.Y1 = 114;
            this.lineShape41.Y2 = 144;
            this.lineShape41.Click += new System.EventHandler(this.lineShape41_Click);
            this.lineShape41.MouseEnter += new System.EventHandler(this.lineShape41_MouseEnter);
            this.lineShape41.MouseLeave += new System.EventHandler(this.lineShape41_MouseLeave);
            // 
            // lineShape40
            // 
            this.lineShape40.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape40.BorderWidth = 4;
            this.lineShape40.Name = "lineShape40";
            this.lineShape40.X1 = 24;
            this.lineShape40.X2 = 54;
            this.lineShape40.Y1 = 114;
            this.lineShape40.Y2 = 114;
            this.lineShape40.Click += new System.EventHandler(this.lineShape40_Click);
            this.lineShape40.MouseEnter += new System.EventHandler(this.lineShape40_MouseEnter);
            this.lineShape40.MouseLeave += new System.EventHandler(this.lineShape40_MouseLeave);
            // 
            // lineShape39
            // 
            this.lineShape39.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape39.BorderWidth = 4;
            this.lineShape39.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape39.Name = "lineShape39";
            this.lineShape39.X1 = 174;
            this.lineShape39.X2 = 174;
            this.lineShape39.Y1 = 114;
            this.lineShape39.Y2 = 144;
            this.lineShape39.Click += new System.EventHandler(this.lineShape39_Click);
            this.lineShape39.MouseEnter += new System.EventHandler(this.lineShape39_MouseEnter);
            this.lineShape39.MouseLeave += new System.EventHandler(this.lineShape39_MouseLeave);
            // 
            // lineShape38
            // 
            this.lineShape38.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape38.BorderWidth = 4;
            this.lineShape38.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape38.Name = "lineShape38";
            this.lineShape38.X1 = 144;
            this.lineShape38.X2 = 144;
            this.lineShape38.Y1 = 114;
            this.lineShape38.Y2 = 144;
            this.lineShape38.Click += new System.EventHandler(this.lineShape38_Click);
            this.lineShape38.MouseEnter += new System.EventHandler(this.lineShape38_MouseEnter);
            this.lineShape38.MouseLeave += new System.EventHandler(this.lineShape38_MouseLeave);
            // 
            // lineShape37
            // 
            this.lineShape37.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape37.BorderWidth = 4;
            this.lineShape37.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape37.Name = "lineShape37";
            this.lineShape37.X1 = 114;
            this.lineShape37.X2 = 114;
            this.lineShape37.Y1 = 114;
            this.lineShape37.Y2 = 144;
            this.lineShape37.Click += new System.EventHandler(this.lineShape37_Click);
            this.lineShape37.MouseEnter += new System.EventHandler(this.lineShape37_MouseEnter);
            this.lineShape37.MouseLeave += new System.EventHandler(this.lineShape37_MouseLeave);
            // 
            // lineShape36
            // 
            this.lineShape36.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape36.BorderWidth = 4;
            this.lineShape36.Name = "lineShape36";
            this.lineShape36.X1 = 144;
            this.lineShape36.X2 = 174;
            this.lineShape36.Y1 = 114;
            this.lineShape36.Y2 = 114;
            this.lineShape36.Click += new System.EventHandler(this.lineShape36_Click);
            this.lineShape36.MouseEnter += new System.EventHandler(this.lineShape36_MouseEnter);
            this.lineShape36.MouseLeave += new System.EventHandler(this.lineShape36_MouseLeave);
            // 
            // lineShape35
            // 
            this.lineShape35.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape35.BorderWidth = 4;
            this.lineShape35.Name = "lineShape35";
            this.lineShape35.X1 = 84;
            this.lineShape35.X2 = 114;
            this.lineShape35.Y1 = 114;
            this.lineShape35.Y2 = 114;
            this.lineShape35.Click += new System.EventHandler(this.lineShape35_Click);
            this.lineShape35.MouseEnter += new System.EventHandler(this.lineShape35_MouseEnter);
            this.lineShape35.MouseLeave += new System.EventHandler(this.lineShape35_MouseLeave);
            // 
            // lineShape34
            // 
            this.lineShape34.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape34.BorderWidth = 4;
            this.lineShape34.Name = "lineShape34";
            this.lineShape34.X1 = 114;
            this.lineShape34.X2 = 144;
            this.lineShape34.Y1 = 114;
            this.lineShape34.Y2 = 114;
            this.lineShape34.Click += new System.EventHandler(this.lineShape34_Click);
            this.lineShape34.MouseEnter += new System.EventHandler(this.lineShape34_MouseEnter);
            this.lineShape34.MouseLeave += new System.EventHandler(this.lineShape34_MouseLeave);
            // 
            // lineShape33
            // 
            this.lineShape33.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape33.BorderWidth = 4;
            this.lineShape33.Name = "lineShape33";
            this.lineShape33.X1 = 54;
            this.lineShape33.X2 = 84;
            this.lineShape33.Y1 = 84;
            this.lineShape33.Y2 = 84;
            this.lineShape33.Click += new System.EventHandler(this.lineShape33_Click);
            this.lineShape33.MouseEnter += new System.EventHandler(this.lineShape33_MouseEnter);
            this.lineShape33.MouseLeave += new System.EventHandler(this.lineShape33_MouseLeave);
            // 
            // lineShape32
            // 
            this.lineShape32.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape32.BorderWidth = 4;
            this.lineShape32.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape32.Name = "lineShape32";
            this.lineShape32.X1 = 84;
            this.lineShape32.X2 = 84;
            this.lineShape32.Y1 = 84;
            this.lineShape32.Y2 = 114;
            this.lineShape32.Click += new System.EventHandler(this.lineShape32_Click);
            this.lineShape32.MouseEnter += new System.EventHandler(this.lineShape32_MouseEnter);
            this.lineShape32.MouseLeave += new System.EventHandler(this.lineShape32_MouseLeave);
            // 
            // lineShape31
            // 
            this.lineShape31.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape31.BorderWidth = 4;
            this.lineShape31.Name = "lineShape31";
            this.lineShape31.X1 = 54;
            this.lineShape31.X2 = 54;
            this.lineShape31.Y1 = 84;
            this.lineShape31.Y2 = 114;
            this.lineShape31.Click += new System.EventHandler(this.lineShape31_Click);
            this.lineShape31.MouseEnter += new System.EventHandler(this.lineShape31_MouseEnter);
            this.lineShape31.MouseLeave += new System.EventHandler(this.lineShape31_MouseLeave);
            // 
            // lineShape30
            // 
            this.lineShape30.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape30.BorderWidth = 4;
            this.lineShape30.Name = "lineShape30";
            this.lineShape30.X1 = 24;
            this.lineShape30.X2 = 24;
            this.lineShape30.Y1 = 84;
            this.lineShape30.Y2 = 114;
            this.lineShape30.Click += new System.EventHandler(this.lineShape30_Click);
            this.lineShape30.MouseEnter += new System.EventHandler(this.lineShape30_MouseEnter);
            this.lineShape30.MouseLeave += new System.EventHandler(this.lineShape30_MouseLeave);
            // 
            // lineShape29
            // 
            this.lineShape29.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape29.BorderWidth = 4;
            this.lineShape29.Name = "lineShape29";
            this.lineShape29.X1 = 24;
            this.lineShape29.X2 = 54;
            this.lineShape29.Y1 = 84;
            this.lineShape29.Y2 = 84;
            this.lineShape29.Click += new System.EventHandler(this.lineShape29_Click);
            this.lineShape29.MouseEnter += new System.EventHandler(this.lineShape29_MouseEnter);
            this.lineShape29.MouseLeave += new System.EventHandler(this.lineShape29_MouseLeave);
            // 
            // lineShape28
            // 
            this.lineShape28.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape28.BorderWidth = 4;
            this.lineShape28.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape28.Name = "lineShape28";
            this.lineShape28.X1 = 174;
            this.lineShape28.X2 = 174;
            this.lineShape28.Y1 = 84;
            this.lineShape28.Y2 = 114;
            this.lineShape28.Click += new System.EventHandler(this.lineShape28_Click);
            this.lineShape28.MouseEnter += new System.EventHandler(this.lineShape28_MouseEnter);
            this.lineShape28.MouseLeave += new System.EventHandler(this.lineShape28_MouseLeave);
            // 
            // lineShape27
            // 
            this.lineShape27.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape27.BorderWidth = 4;
            this.lineShape27.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape27.Name = "lineShape27";
            this.lineShape27.X1 = 144;
            this.lineShape27.X2 = 144;
            this.lineShape27.Y1 = 84;
            this.lineShape27.Y2 = 114;
            this.lineShape27.Click += new System.EventHandler(this.lineShape27_Click);
            this.lineShape27.MouseEnter += new System.EventHandler(this.lineShape27_MouseEnter);
            this.lineShape27.MouseLeave += new System.EventHandler(this.lineShape27_MouseLeave);
            // 
            // lineShape26
            // 
            this.lineShape26.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape26.BorderWidth = 4;
            this.lineShape26.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape26.Name = "lineShape26";
            this.lineShape26.X1 = 114;
            this.lineShape26.X2 = 114;
            this.lineShape26.Y1 = 84;
            this.lineShape26.Y2 = 114;
            this.lineShape26.Click += new System.EventHandler(this.lineShape26_Click);
            this.lineShape26.MouseEnter += new System.EventHandler(this.lineShape26_MouseEnter);
            this.lineShape26.MouseLeave += new System.EventHandler(this.lineShape26_MouseLeave);
            // 
            // lineShape25
            // 
            this.lineShape25.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape25.BorderWidth = 4;
            this.lineShape25.Name = "lineShape25";
            this.lineShape25.X1 = 144;
            this.lineShape25.X2 = 174;
            this.lineShape25.Y1 = 84;
            this.lineShape25.Y2 = 84;
            this.lineShape25.Click += new System.EventHandler(this.lineShape25_Click);
            this.lineShape25.MouseEnter += new System.EventHandler(this.lineShape25_MouseEnter);
            this.lineShape25.MouseLeave += new System.EventHandler(this.lineShape25_MouseLeave);
            // 
            // lineShape24
            // 
            this.lineShape24.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape24.BorderWidth = 4;
            this.lineShape24.Name = "lineShape24";
            this.lineShape24.X1 = 84;
            this.lineShape24.X2 = 114;
            this.lineShape24.Y1 = 84;
            this.lineShape24.Y2 = 84;
            this.lineShape24.Click += new System.EventHandler(this.lineShape24_Click);
            this.lineShape24.MouseEnter += new System.EventHandler(this.lineShape24_MouseEnter);
            this.lineShape24.MouseLeave += new System.EventHandler(this.lineShape24_MouseLeave);
            // 
            // lineShape23
            // 
            this.lineShape23.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape23.BorderWidth = 4;
            this.lineShape23.Name = "lineShape23";
            this.lineShape23.X1 = 114;
            this.lineShape23.X2 = 144;
            this.lineShape23.Y1 = 84;
            this.lineShape23.Y2 = 84;
            this.lineShape23.Click += new System.EventHandler(this.lineShape23_Click);
            this.lineShape23.MouseEnter += new System.EventHandler(this.lineShape23_MouseEnter);
            this.lineShape23.MouseLeave += new System.EventHandler(this.lineShape23_MouseLeave);
            // 
            // lineShape22
            // 
            this.lineShape22.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape22.BorderWidth = 4;
            this.lineShape22.Name = "lineShape22";
            this.lineShape22.X1 = 54;
            this.lineShape22.X2 = 84;
            this.lineShape22.Y1 = 54;
            this.lineShape22.Y2 = 54;
            this.lineShape22.Click += new System.EventHandler(this.lineShape22_Click);
            this.lineShape22.MouseEnter += new System.EventHandler(this.lineShape22_MouseEnter);
            this.lineShape22.MouseLeave += new System.EventHandler(this.lineShape22_MouseLeave);
            // 
            // lineShape21
            // 
            this.lineShape21.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape21.BorderWidth = 4;
            this.lineShape21.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape21.Name = "lineShape21";
            this.lineShape21.X1 = 84;
            this.lineShape21.X2 = 84;
            this.lineShape21.Y1 = 54;
            this.lineShape21.Y2 = 84;
            this.lineShape21.Click += new System.EventHandler(this.lineShape21_Click);
            this.lineShape21.MouseEnter += new System.EventHandler(this.lineShape21_MouseEnter);
            this.lineShape21.MouseLeave += new System.EventHandler(this.lineShape21_MouseLeave);
            // 
            // lineShape20
            // 
            this.lineShape20.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape20.BorderWidth = 4;
            this.lineShape20.Name = "lineShape20";
            this.lineShape20.X1 = 54;
            this.lineShape20.X2 = 54;
            this.lineShape20.Y1 = 54;
            this.lineShape20.Y2 = 84;
            this.lineShape20.Click += new System.EventHandler(this.lineShape20_Click);
            this.lineShape20.MouseEnter += new System.EventHandler(this.lineShape20_MouseEnter);
            this.lineShape20.MouseLeave += new System.EventHandler(this.lineShape20_MouseLeave);
            // 
            // lineShape19
            // 
            this.lineShape19.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape19.BorderWidth = 4;
            this.lineShape19.Name = "lineShape19";
            this.lineShape19.X1 = 24;
            this.lineShape19.X2 = 24;
            this.lineShape19.Y1 = 54;
            this.lineShape19.Y2 = 84;
            this.lineShape19.Click += new System.EventHandler(this.lineShape19_Click);
            this.lineShape19.MouseEnter += new System.EventHandler(this.lineShape19_MouseEnter);
            this.lineShape19.MouseLeave += new System.EventHandler(this.lineShape19_MouseLeave);
            // 
            // lineShape18
            // 
            this.lineShape18.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape18.BorderWidth = 4;
            this.lineShape18.Name = "lineShape18";
            this.lineShape18.X1 = 24;
            this.lineShape18.X2 = 54;
            this.lineShape18.Y1 = 54;
            this.lineShape18.Y2 = 54;
            this.lineShape18.Click += new System.EventHandler(this.lineShape18_Click);
            this.lineShape18.MouseEnter += new System.EventHandler(this.lineShape18_MouseEnter);
            this.lineShape18.MouseLeave += new System.EventHandler(this.lineShape18_MouseLeave);
            // 
            // lineShape17
            // 
            this.lineShape17.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape17.BorderWidth = 4;
            this.lineShape17.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape17.Name = "lineShape17";
            this.lineShape17.X1 = 174;
            this.lineShape17.X2 = 174;
            this.lineShape17.Y1 = 54;
            this.lineShape17.Y2 = 84;
            this.lineShape17.Click += new System.EventHandler(this.lineShape17_Click);
            this.lineShape17.MouseEnter += new System.EventHandler(this.lineShape17_MouseEnter);
            this.lineShape17.MouseLeave += new System.EventHandler(this.lineShape17_MouseLeave);
            // 
            // lineShape16
            // 
            this.lineShape16.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape16.BorderWidth = 4;
            this.lineShape16.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape16.Name = "lineShape16";
            this.lineShape16.X1 = 144;
            this.lineShape16.X2 = 144;
            this.lineShape16.Y1 = 54;
            this.lineShape16.Y2 = 84;
            this.lineShape16.Click += new System.EventHandler(this.lineShape16_Click);
            this.lineShape16.MouseEnter += new System.EventHandler(this.lineShape16_MouseEnter);
            this.lineShape16.MouseLeave += new System.EventHandler(this.lineShape16_MouseLeave);
            // 
            // lineShape15
            // 
            this.lineShape15.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape15.BorderWidth = 4;
            this.lineShape15.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape15.Name = "lineShape15";
            this.lineShape15.X1 = 114;
            this.lineShape15.X2 = 114;
            this.lineShape15.Y1 = 54;
            this.lineShape15.Y2 = 84;
            this.lineShape15.Click += new System.EventHandler(this.lineShape15_Click);
            this.lineShape15.MouseEnter += new System.EventHandler(this.lineShape15_MouseEnter);
            this.lineShape15.MouseLeave += new System.EventHandler(this.lineShape15_MouseLeave);
            // 
            // lineShape14
            // 
            this.lineShape14.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape14.BorderWidth = 4;
            this.lineShape14.Name = "lineShape14";
            this.lineShape14.X1 = 144;
            this.lineShape14.X2 = 174;
            this.lineShape14.Y1 = 54;
            this.lineShape14.Y2 = 54;
            this.lineShape14.Click += new System.EventHandler(this.lineShape14_Click);
            this.lineShape14.MouseEnter += new System.EventHandler(this.lineShape14_MouseEnter);
            this.lineShape14.MouseLeave += new System.EventHandler(this.lineShape14_MouseLeave);
            // 
            // lineShape13
            // 
            this.lineShape13.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape13.BorderWidth = 4;
            this.lineShape13.Name = "lineShape13";
            this.lineShape13.X1 = 84;
            this.lineShape13.X2 = 114;
            this.lineShape13.Y1 = 54;
            this.lineShape13.Y2 = 54;
            this.lineShape13.Click += new System.EventHandler(this.lineShape13_Click);
            this.lineShape13.MouseEnter += new System.EventHandler(this.lineShape13_MouseEnter);
            this.lineShape13.MouseLeave += new System.EventHandler(this.lineShape13_MouseLeave);
            // 
            // lineShape8
            // 
            this.lineShape8.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape8.BorderWidth = 4;
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 114;
            this.lineShape8.X2 = 144;
            this.lineShape8.Y1 = 54;
            this.lineShape8.Y2 = 54;
            this.lineShape8.Click += new System.EventHandler(this.lineShape8_Click);
            this.lineShape8.MouseEnter += new System.EventHandler(this.lineShape8_MouseEnter);
            this.lineShape8.MouseLeave += new System.EventHandler(this.lineShape8_MouseLeave);
            // 
            // lineShape12
            // 
            this.lineShape12.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape12.BorderWidth = 4;
            this.lineShape12.Name = "lineShape12";
            this.lineShape12.X1 = 144;
            this.lineShape12.X2 = 174;
            this.lineShape12.Y1 = 24;
            this.lineShape12.Y2 = 24;
            this.lineShape12.Click += new System.EventHandler(this.lineShape12_Click);
            this.lineShape12.MouseEnter += new System.EventHandler(this.lineShape12_MouseEnter);
            this.lineShape12.MouseLeave += new System.EventHandler(this.lineShape12_MouseLeave);
            // 
            // lineShape11
            // 
            this.lineShape11.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape11.BorderWidth = 4;
            this.lineShape11.Name = "lineShape11";
            this.lineShape11.X1 = 114;
            this.lineShape11.X2 = 144;
            this.lineShape11.Y1 = 24;
            this.lineShape11.Y2 = 24;
            this.lineShape11.Click += new System.EventHandler(this.lineShape11_Click);
            this.lineShape11.MouseEnter += new System.EventHandler(this.lineShape11_MouseEnter);
            this.lineShape11.MouseLeave += new System.EventHandler(this.lineShape11_MouseLeave);
            // 
            // lineShape10
            // 
            this.lineShape10.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape10.BorderWidth = 4;
            this.lineShape10.Name = "lineShape10";
            this.lineShape10.X1 = 84;
            this.lineShape10.X2 = 114;
            this.lineShape10.Y1 = 24;
            this.lineShape10.Y2 = 24;
            this.lineShape10.Click += new System.EventHandler(this.lineShape10_Click);
            this.lineShape10.MouseEnter += new System.EventHandler(this.lineShape10_MouseEnter);
            this.lineShape10.MouseLeave += new System.EventHandler(this.lineShape10_MouseLeave);
            // 
            // lineShape9
            // 
            this.lineShape9.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape9.BorderWidth = 4;
            this.lineShape9.Name = "lineShape9";
            this.lineShape9.X1 = 54;
            this.lineShape9.X2 = 84;
            this.lineShape9.Y1 = 24;
            this.lineShape9.Y2 = 24;
            this.lineShape9.Click += new System.EventHandler(this.lineShape9_Click);
            this.lineShape9.MouseEnter += new System.EventHandler(this.lineShape9_MouseEnter);
            this.lineShape9.MouseLeave += new System.EventHandler(this.lineShape9_MouseLeave);
            // 
            // lineShape7
            // 
            this.lineShape7.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape7.BorderWidth = 4;
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 24;
            this.lineShape7.X2 = 54;
            this.lineShape7.Y1 = 24;
            this.lineShape7.Y2 = 24;
            this.lineShape7.Click += new System.EventHandler(this.lineShape7_Click);
            this.lineShape7.MouseEnter += new System.EventHandler(this.lineShape7_MouseEnter);
            this.lineShape7.MouseLeave += new System.EventHandler(this.lineShape7_MouseLeave);
            // 
            // lineShape6
            // 
            this.lineShape6.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape6.BorderWidth = 4;
            this.lineShape6.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.SelectionColor = System.Drawing.SystemColors.Control;
            this.lineShape6.X1 = 174;
            this.lineShape6.X2 = 174;
            this.lineShape6.Y1 = 24;
            this.lineShape6.Y2 = 54;
            this.lineShape6.Click += new System.EventHandler(this.lineShape6_Click);
            this.lineShape6.MouseEnter += new System.EventHandler(this.lineShape6_MouseEnter);
            this.lineShape6.MouseLeave += new System.EventHandler(this.lineShape6_MouseLeave);
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape5.BorderWidth = 4;
            this.lineShape5.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape5.Name = "lineShape2";
            this.lineShape5.X1 = 144;
            this.lineShape5.X2 = 144;
            this.lineShape5.Y1 = 24;
            this.lineShape5.Y2 = 54;
            this.lineShape5.Click += new System.EventHandler(this.lineShape5_Click);
            this.lineShape5.MouseEnter += new System.EventHandler(this.lineShape5_MouseEnter);
            this.lineShape5.MouseLeave += new System.EventHandler(this.lineShape5_MouseLeave);
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape4.BorderWidth = 4;
            this.lineShape4.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape4.Name = "lineShape2";
            this.lineShape4.X1 = 114;
            this.lineShape4.X2 = 114;
            this.lineShape4.Y1 = 24;
            this.lineShape4.Y2 = 54;
            this.lineShape4.Click += new System.EventHandler(this.lineShape4_Click);
            this.lineShape4.MouseEnter += new System.EventHandler(this.lineShape4_MouseEnter);
            this.lineShape4.MouseLeave += new System.EventHandler(this.lineShape4_MouseLeave);
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape3.BorderWidth = 4;
            this.lineShape3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape3.Name = "lineShape2";
            this.lineShape3.X1 = 84;
            this.lineShape3.X2 = 84;
            this.lineShape3.Y1 = 24;
            this.lineShape3.Y2 = 54;
            this.lineShape3.Click += new System.EventHandler(this.lineShape3_Click);
            this.lineShape3.MouseEnter += new System.EventHandler(this.lineShape3_MouseEnter);
            this.lineShape3.MouseLeave += new System.EventHandler(this.lineShape3_MouseLeave);
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape2.BorderWidth = 4;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 54;
            this.lineShape2.X2 = 54;
            this.lineShape2.Y1 = 24;
            this.lineShape2.Y2 = 54;
            this.lineShape2.Click += new System.EventHandler(this.lineShape2_Click);
            this.lineShape2.MouseEnter += new System.EventHandler(this.lineShape2_MouseEnter);
            this.lineShape2.MouseLeave += new System.EventHandler(this.lineShape2_MouseLeave);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape1.BorderWidth = 4;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 24;
            this.lineShape1.X2 = 24;
            this.lineShape1.Y1 = 24;
            this.lineShape1.Y2 = 54;
            this.lineShape1.Click += new System.EventHandler(this.lineShape1_Click);
            this.lineShape1.MouseEnter += new System.EventHandler(this.lineShape1_MouseEnter);
            this.lineShape1.MouseLeave += new System.EventHandler(this.lineShape1_MouseLeave);
            // 
            // lineShape60
            // 
            this.lineShape60.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape60.BorderWidth = 4;
            this.lineShape60.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape60.Name = "lineShape60";
            this.lineShape60.X1 = 114;
            this.lineShape60.X2 = 114;
            this.lineShape60.Y1 = 144;
            this.lineShape60.Y2 = 174;
            this.lineShape60.Click += new System.EventHandler(this.lineShape60_Click);
            this.lineShape60.MouseEnter += new System.EventHandler(this.lineShape60_MouseEnter);
            this.lineShape60.MouseLeave += new System.EventHandler(this.lineShape60_MouseLeave);
            // 
            // lineShape59
            // 
            this.lineShape59.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape59.BorderWidth = 4;
            this.lineShape59.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape59.Name = "lineShape59";
            this.lineShape59.X1 = 144;
            this.lineShape59.X2 = 144;
            this.lineShape59.Y1 = 144;
            this.lineShape59.Y2 = 174;
            this.lineShape59.Click += new System.EventHandler(this.lineShape59_Click);
            this.lineShape59.MouseEnter += new System.EventHandler(this.lineShape59_MouseEnter);
            this.lineShape59.MouseLeave += new System.EventHandler(this.lineShape59_MouseLeave);
            // 
            // lineShape58
            // 
            this.lineShape58.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape58.BorderWidth = 4;
            this.lineShape58.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape58.Name = "lineShape58";
            this.lineShape58.X1 = 174;
            this.lineShape58.X2 = 174;
            this.lineShape58.Y1 = 144;
            this.lineShape58.Y2 = 174;
            this.lineShape58.Click += new System.EventHandler(this.lineShape58_Click);
            this.lineShape58.MouseEnter += new System.EventHandler(this.lineShape58_MouseEnter);
            this.lineShape58.MouseLeave += new System.EventHandler(this.lineShape58_MouseLeave);
            // 
            // lineShape57
            // 
            this.lineShape57.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape57.BorderWidth = 4;
            this.lineShape57.Name = "lineShape57";
            this.lineShape57.X1 = 24;
            this.lineShape57.X2 = 24;
            this.lineShape57.Y1 = 144;
            this.lineShape57.Y2 = 174;
            this.lineShape57.Click += new System.EventHandler(this.lineShape57_Click);
            this.lineShape57.MouseEnter += new System.EventHandler(this.lineShape57_MouseEnter);
            this.lineShape57.MouseLeave += new System.EventHandler(this.lineShape57_MouseLeave);
            // 
            // lineShape56
            // 
            this.lineShape56.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape56.BorderWidth = 4;
            this.lineShape56.Name = "lineShape56";
            this.lineShape56.X1 = 54;
            this.lineShape56.X2 = 54;
            this.lineShape56.Y1 = 144;
            this.lineShape56.Y2 = 174;
            this.lineShape56.Click += new System.EventHandler(this.lineShape56_Click);
            this.lineShape56.MouseEnter += new System.EventHandler(this.lineShape56_MouseEnter);
            this.lineShape56.MouseLeave += new System.EventHandler(this.lineShape56_MouseLeave);
            // 
            // lineShape54
            // 
            this.lineShape54.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape54.BorderWidth = 4;
            this.lineShape54.Cursor = System.Windows.Forms.Cursors.Default;
            this.lineShape54.Name = "lineShape54";
            this.lineShape54.X1 = 84;
            this.lineShape54.X2 = 84;
            this.lineShape54.Y1 = 144;
            this.lineShape54.Y2 = 174;
            this.lineShape54.Click += new System.EventHandler(this.lineShape54_Click);
            this.lineShape54.MouseEnter += new System.EventHandler(this.lineShape54_MouseEnter);
            this.lineShape54.MouseLeave += new System.EventHandler(this.lineShape54_MouseLeave);
            // 
            // lineShape53
            // 
            this.lineShape53.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape53.BorderWidth = 4;
            this.lineShape53.Name = "lineShape53";
            this.lineShape53.X1 = 114;
            this.lineShape53.X2 = 144;
            this.lineShape53.Y1 = 174;
            this.lineShape53.Y2 = 174;
            this.lineShape53.Click += new System.EventHandler(this.lineShape53_Click);
            this.lineShape53.MouseEnter += new System.EventHandler(this.lineShape53_MouseEnter);
            this.lineShape53.MouseLeave += new System.EventHandler(this.lineShape53_MouseLeave);
            // 
            // lineShape52
            // 
            this.lineShape52.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape52.BorderWidth = 4;
            this.lineShape52.Name = "lineShape52";
            this.lineShape52.X1 = 84;
            this.lineShape52.X2 = 114;
            this.lineShape52.Y1 = 174;
            this.lineShape52.Y2 = 174;
            this.lineShape52.Click += new System.EventHandler(this.lineShape52_Click);
            this.lineShape52.MouseEnter += new System.EventHandler(this.lineShape52_MouseEnter);
            this.lineShape52.MouseLeave += new System.EventHandler(this.lineShape52_MouseLeave);
            // 
            // lineShape50
            // 
            this.lineShape50.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape50.BorderWidth = 4;
            this.lineShape50.Name = "lineShape50";
            this.lineShape50.X1 = 144;
            this.lineShape50.X2 = 174;
            this.lineShape50.Y1 = 174;
            this.lineShape50.Y2 = 174;
            this.lineShape50.Click += new System.EventHandler(this.lineShape50_Click);
            this.lineShape50.MouseEnter += new System.EventHandler(this.lineShape50_MouseEnter);
            this.lineShape50.MouseLeave += new System.EventHandler(this.lineShape50_MouseLeave);
            // 
            // lineShape49
            // 
            this.lineShape49.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape49.BorderWidth = 4;
            this.lineShape49.Name = "lineShape49";
            this.lineShape49.X1 = 24;
            this.lineShape49.X2 = 54;
            this.lineShape49.Y1 = 174;
            this.lineShape49.Y2 = 174;
            this.lineShape49.Click += new System.EventHandler(this.lineShape49_Click);
            this.lineShape49.MouseEnter += new System.EventHandler(this.lineShape49_MouseEnter);
            this.lineShape49.MouseLeave += new System.EventHandler(this.lineShape49_MouseLeave);
            // 
            // lineShape48
            // 
            this.lineShape48.BorderColor = System.Drawing.SystemColors.Control;
            this.lineShape48.BorderWidth = 4;
            this.lineShape48.Name = "lineShape48";
            this.lineShape48.X1 = 54;
            this.lineShape48.X2 = 84;
            this.lineShape48.Y1 = 174;
            this.lineShape48.Y2 = 174;
            this.lineShape48.Click += new System.EventHandler(this.lineShape48_Click);
            this.lineShape48.MouseEnter += new System.EventHandler(this.lineShape48_MouseEnter);
            this.lineShape48.MouseLeave += new System.EventHandler(this.lineShape48_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(227, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 20);
            this.textBox3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 200);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private void pointConstructor(int size)
        //{
        //    for (int i = 1; i <= size; i++)
        //    {
        //        Microsoft.VisualBasic.PowerPacks.OvalShape circulo = new Microsoft.VisualBasic.PowerPacks.OvalShape();

        //        System.Windows.Forms.Button asdasd = new System.Windows.Forms.Button();

        //        //Initialize label's property
        //        circulo.BackColor = System.Drawing.SystemColors.Control;
        //        circulo.Cursor = System.Windows.Forms.Cursors.Default;
        //        circulo.Location = new System.Drawing.Point(20*i, 20);
        //        circulo.Name = "circulo" + i;
        //        circulo.Size = new System.Drawing.Size(6, 6);

        //        circulosLista.Add(circulo);


        //        //Initialize textBoxes Property
        //        textBoxNewInput.Location = new Point(labelInput.Width, labelInput.Top - 3);

        //        //Add the newly created text box to the list of input text boxes
        //        inputTextBoxes.Add(textBoxNewInput);

        //        //Add the labels and text box to the form
                
        //        this.Controls.Add(circulo);
        //    }

        //    for (int i = 0; i < size; i++)
        //    {

        //    }
        //}

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape37;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape36;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape35;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape34;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape33;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape32;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape31;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape30;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape29;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape28;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape27;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape26;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape25;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape24;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape23;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape22;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape21;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape20;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape19;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape18;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape17;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape16;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape15;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape14;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape13;
        private Microsoft.VisualBasic.PowerPacks.OvalShape asd;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape4;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape3;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape9;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape55;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape51;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape47;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape46;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape45;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape44;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape43;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape42;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape41;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape40;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape39;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape38;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape37;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape36;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape35;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape34;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape33;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape32;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape31;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape30;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape29;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape28;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape27;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape26;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape25;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape24;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape23;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape22;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape21;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape20;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape19;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape18;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape17;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape16;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape15;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape14;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape13;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape12;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape11;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape10;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape60;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape59;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape58;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape57;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape56;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape54;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape53;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape52;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape50;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape49;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape48;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape10;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape9;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape8;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape7;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape6;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

