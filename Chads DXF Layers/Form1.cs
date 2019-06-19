using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chads_DXF_Layers
{
    public partial class Form1 : Form
    {

        ToolList toolList = new ToolList();
        Tool tool = new Tool();

        String layerName;
        String feedRate;
        String feedRateText;
        double workspeed;
        String correction;
        String toolDepth;
        String toolCode;

        public Form1()
        {
            InitializeComponent();
            layerName = "TCHW0B1";
            btnCenter.BackColor = Color.LightGreen;

            // Create toolList
            toolList.addTool(tool.createTool("1290VGRO", "1/2\" 90° V-GROOVE", 9.5, 103.33, 12, 11640, Properties.Resources._1290VGRO));
            toolList.addTool(tool.createTool("1834SCDN", "1/8\" FINISH DOWN 2 FLUTE", 3.2, 102.61, 24, 12000, Properties.Resources._1834SCDN));
            toolList.addTool(tool.createTool("1834SCUP", "1/8\" FINISH UP 2 FLUTE", 3.2, 99.89, 19, 12000, Properties.Resources._1834SCUP));
            toolList.addTool(tool.createTool("12_1FNDN", "LOW HELIX FINISH 3 FLUTE", 12.7, 137.39, 31, 11650, Properties.Resources._12_1FNDN));
            toolList.addTool(tool.createTool("12_1RFUP", "ROUGH UP 1/2\" 3 FLUTE", 12.3, 118.61, 38, 11640, Properties.Resources._12_1RFUP));
            toolList.addTool(tool.createTool("121FNDN2", "1/2\" FINISH 3 FLUTE", 11.6, 163.13, 54, 11640, Properties.Resources._121FNDN2));
            toolList.addTool(tool.createTool("12COMPLY", "COMPRESSION FINISH 2 FLUTE", 12.7, 121.23, 25, 11680, Properties.Resources._12COMPLY));
            toolList.addTool(tool.createTool("12_1COM", "COMPRESSION FINISH 2 FLUTE", 12.7, 124.53, 25, 11640, Properties.Resources._12_1COM));
            toolList.addTool(tool.createTool("34_2RFUP", "3/4\"- 2\" ROUGH UP", 18.6, 156.34, 80, 10850, Properties.Resources._34_2RFUP));
            toolList.addTool(tool.createTool("3MM", "3mm SPIRAL UP CUT ", 3, 103, 16, 12000, Properties.Resources._3MM));
            toolList.addTool(tool.createTool("4MM", "4mm DOWN SHEAR", 3.9, 105.89, 45, 12000, Properties.Resources._4MM));
            toolList.addTool(tool.createTool("5MM", "5mm UP SHEAR", 5, 102.67, 36, 12000, Properties.Resources._4MM));
            toolList.addTool(tool.createTool("38FNDN", "3/8\" 3 FLUTE", 9.2, 132.22, 29, 12000, Properties.Resources._38FNDN));
            toolList.addTool(tool.createTool("16_FNUP", "1/16\" FINISH UP 2 FLUTE", 1.5, 32.86, 6.3, 7500, Properties.Resources._16_FNUP));
            toolList.addTool(tool.createTool("12_1FNUP", "1/2\" FINISH UP 2 FLUTE", 12.7, 123.9, 32, 11640, Properties.Resources._12_1RFUP));
            toolList.addTool(tool.createTool("1434FNUP", "1/4\" FINSIH UP", 6.3, 105.73, 20, 12000, Properties.Resources._1434FNUP));
            toolList.addTool(tool.createTool("34_FNUP", "3/4\" 3 FLUTE", 18.85, 154.22, 80, 10820, Properties.Resources._34_FNUP));
            toolList.addTool(tool.createTool("38_114UP", "3/8\" 2 FLUTE", 9.47, 115, 32, 12000, Properties.Resources._38_114UP));
            toolList.addTool(tool.createTool("114BOWL", "COVE 1-1/4\"", 37.10, 111.61, 32, 12000, Properties.Resources._114BOWL));
            toolList.addTool(tool.createTool("1_1_4CV", "COVE 1-1/4\"X1", 25.1, 133.28, 59, 9990, Properties.Resources._1_1_14CV));
            toolList.addTool(tool.createTool("1.5COVE", "COVE 1-1/2\" 3/4\" RADIUS", 38.10, 118.98, 35, 8250, Properties.Resources._1_5COVE));
            toolList.addTool(tool.createTool("6.4COVE", "COVE 1/4\"", 6.4, 135.8, 36, 12000, Properties.Resources._6_4COVE));
            toolList.addTool(tool.createTool("2COVE", "COVE 2\"", 51, 126, 58, 2500, Properties.Resources._2COVE));
            toolList.addTool(tool.createTool("38COVE", "COVE 38mm", 38.10, 130.42, 55, 2500, Properties.Resources._38COVE));
            toolList.addTool(tool.createTool("114RDOVR", "ROUND OVER 1-1/4\"", 12.7, 133.28, 33.3, 9500, Properties.Resources._114RDOVR));
            toolList.addTool(tool.createTool("1RDOVR", "ROUND OVER 1\"", 12.7, 123.88, 25.10, 9180, Properties.Resources._1RDOVR));
            toolList.addTool(tool.createTool("38RDOVR", "ROUND OVER 3/8\"", 12.9, 108.7, 37, 11640, Properties.Resources._38RDOVR));
            toolList.addTool(tool.createTool("GRUB", "HODGDON GRUB CUTTER/WATERFALL", 12, 128, 12.7, 3500, Properties.Resources.GRUB));
            toolList.addTool(tool.createTool("112HOG", "HOG OUT 1-1/2\" *NEES A LEAD IN*", 37.10, 104.67, 35, 8390, Properties.Resources._112HOG));
            toolList.addTool(tool.createTool("CAPA1", "CAPRAIL OUTER ROUND OVER", 79.42, 102.26, 48.25, 3500, Properties.Resources.CAPA1));
            toolList.addTool(tool.createTool("CAPA2", "CAPRAIL UPPER 20\"RADIUS", 62, 103.66, 13, 4000, Properties.Resources.CAPA2));
            toolList.addTool(tool.createTool("SPLINE15", "15.5mm SPLINE", 98.6, 118.94, 38, 3800, Properties.Resources.SPLINE15));
            toolList.addTool(tool.createTool("1FLUTE", "1\" STRAIGHT FINISH 2 FLUTE", 25.4, 45, 35, 9946, Properties.Resources._1FLUTE));
            toolList.addTool(tool.createTool("15DEG_BV", "15DEG BEVEL", 25.7, 130, 27, 9906, Properties.Resources._15DEG_BV));
            toolList.addTool(tool.createTool("38NOSE", "3/8\" RADIUS ROUND NOSE", 19, 151.21, 57, 10800, Properties.Resources._38NOSEa));
            toolList.addTool(tool.createTool("58RUF", "5/8\" ROUGHER", 15.76, 153, 52, 11230, Properties.Resources._58RUF));
            toolList.addTool(tool.createTool("18ESTHEC", "BIT FOR CUTTING ESTHEC PERIMETER", 3.1, 94.3, 12.7, 4000, Properties.Resources._18ESTHEC));
            toolList.addTool(tool.createTool("CCTOE", "CHRIS CRAFT TOE RAIL CUTTER", 70, 102.78, 8.2, 4000, Properties.Resources.CCTOE));
            toolList.addTool(tool.createTool("BV_BOWL", "BEVEL BOWL BIT FOR CC TABLES", 44.1, 112, 34, 7931, Properties.Resources.BV_BOWL));
            toolList.addTool(tool.createTool("34_4FLY", "4\" DIA. FLY CUT", 101.6, 107.43, 6, 12000, Properties.Resources.MAC));
            toolList.addTool(tool.createTool("5_16COVE", "5/8\" DIA. ROUND NOSE BIT", 15.8, 122.71, 48, 11226, Properties.Resources._5_16COVE));
            toolList.addTool(tool.createTool("1_3RFUP", "1\" ROUGHER 3\" CUT DEPTH", 25.3, 160, 83, 10000, Properties.Resources._1_3RFUP));
            toolList.addTool(tool.createTool("18FINGER", "1/8\" RASP BIT FOR ESTHEC FINGERS", 3.1, 19, 12.7, 1200, Properties.Resources._18FINGER));
            toolList.addTool(tool.createTool("FENODRIL", "1/4\" V POINT DRILL FOR PHENOLIC", 6.3, 125, 35, 3000, Properties.Resources.FENODRIL));
            toolList.addTool(tool.createTool("1434FNDN", "6mm SPIRAL DOWN", 6.3, 113.34, 29, 9600, Properties.Resources._1434FNUP));
            toolList.addTool(tool.createTool("1_COVE", "1\" DIAMETER COVE BIT", 25.4, 52, 32, 9900, Properties.Resources._1_COVE));
            toolList.addTool(tool.createTool("12FNRFDN", "1/2\" Finish Rough Downshear", 12.7, 128, 41, 12000, Properties.Resources._12FNRFDN));



      



            // Add tools to the combobox
            foreach (Tool aTool in toolList.tools)
            {
                cmbTools.Items.Add(aTool.getToolCode());
            }

        }

        // Do when toolcode is selected
        private void cmbTools_SelectedIndexChanged(object sender, EventArgs e)
        {
            setTool();
        }

        // Select tool and appropriate settings to display in form
        private void setTool()
        {
            Tool foundTool;
            txtLayerName.Text = cmbTools.SelectedItem.ToString();

            foundTool = toolList.searchTools(cmbTools.SelectedItem.ToString());

            toolCode = foundTool.getToolCode();


            workspeed = foundTool.getWorkSpeed();
            txtWorkSpeed.Text = workspeed.ToString();

            object image = foundTool.getImage();

            pictureBoxTool.Image = (Bitmap)image;

            lblDescription.Text = foundTool.getDescription() + " | Diameter: " + foundTool.getDiameter().ToString()
                + " | Max Length: " + foundTool.getMaxLength() + " | Effective Length: " + foundTool.getEffectiveLength();

            cmbPercent.Text = "100%";
            feedRate = "";

            millingLayerName();
        }

        // Set milling layer name box
        private void millingLayerName()
        {
            txtLayerName.Text = layerName + "TCD$" + toolCode + "$" + feedRateText + correction + toolDepth;
        }

        // Set boring layer name box
        private void boringLayerName()
        {
            txtLayerName.Text = layerName + "TCD$" + toolCode + "$" + toolDepth;
        }

        // Enable boring
        private void chkBoring_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoring.Checked)
            {
                txtWorkSpeed.Visible = false;
                lblWorkSpeed.Visible = false;
                cmbPercent.Visible = false;
                btnCenter.Visible = false;
                btnRight.Visible = false;
                btnLeft.Visible = false;
                layerName = "TCHW0B2";
                boringLayerName();
            }   else
            {
                txtWorkSpeed.Visible = true;
                lblWorkSpeed.Visible = true;
                cmbPercent.Visible = true;
                btnCenter.Visible = true;
                btnRight.Visible = true;
                btnLeft.Visible = true;
                layerName = "TCHW0B1";
                millingLayerName();
            }
        }

        // Copy to clipboard
        private void btnCopy_Click(object sender, EventArgs e)
        {
            txtLayerName.SelectAll();
            txtLayerName.Copy();
        }

        // Set correction to CENTER
        private void btnCenter_Click(object sender, EventArgs e)
        {
            correction = "";
            millingLayerName();
            btnCenter.BackColor = Color.LightGreen;
            btnLeft.BackColor = Color.Gainsboro;
            btnRight.BackColor = Color.Gainsboro;
        }

        // Set correction to LEFT
        private void btnLeft_Click(object sender, EventArgs e)
        {
            correction = "TC2";
            millingLayerName();
            btnCenter.BackColor = Color.Gainsboro;
            btnLeft.BackColor = Color.LightGreen;
            btnRight.BackColor = Color.Gainsboro;
        }

        // Set correction to RIGHT
        private void btnRight_Click(object sender, EventArgs e)
        {
            correction = "TC1";
            millingLayerName();
            btnCenter.BackColor = Color.Gainsboro;
            btnLeft.BackColor = Color.Gainsboro;
            btnRight.BackColor = Color.LightGreen;
        }

        // Keep Form on top
        private void chkOnTop_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkOnTop.Checked)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }

        // Milling tool depth
        private void txtToolDepth_TextChanged(object sender, EventArgs e)
        {
            if (txtToolDepth.Text == "") 
            {
           
            } else
            {
                try
                {
                    if (double.TryParse(txtToolDepth.Text, out double n))
                    {
                        toolDepth = "D" + double.Parse(txtToolDepth.Text) * 100;
                        millingLayerName();
                    } else
                    {
                        MessageBox.Show("You must use a valid number.");
                        txtToolDepth.Text = "";
                        toolDepth = "";
                    }

                }
                catch (FormatException f)
                {
                    txtToolDepth.Text = "";
                    toolDepth = "";
                    MessageBox.Show("You must use a valid number.");

                    throw;

                } catch(Exception ex)
                {
                    MessageBox.Show("Opps, something went wrong.");
                }
            }


        }

        // Change the workspeed by percentage
        private void cmbPercent_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPercent.Text)
            {
                case "100%":
                    feedRate = workspeed.ToString();
                    txtWorkSpeed.Text = feedRate;
                    feedRateText = "";
                    millingLayerName();
                    break;
                case "90%":
                    feedRate = (workspeed * 0.9).ToString();
                    txtWorkSpeed.Text = feedRate;
                    feedRateText = "F" + feedRate;
                    millingLayerName();
                    break;
                case "80%":
                    feedRate = (workspeed * 0.8).ToString();
                    txtWorkSpeed.Text = feedRate;
                    feedRateText = "F" + feedRate;
                    millingLayerName();
                    break;
                case "70%":
                    feedRate = (workspeed * 0.7).ToString();
                    txtWorkSpeed.Text = feedRate;
                    feedRateText = "F" + feedRate;
                    millingLayerName();
                    break;
                case "60%":
                    feedRate = (workspeed * 0.6).ToString();
                    txtWorkSpeed.Text = feedRate;
                    feedRateText = "F" + feedRate;
                    millingLayerName();
                    break;
                case "50%":
                    feedRate = (workspeed * 0.5).ToString();
                    txtWorkSpeed.Text = feedRate;
                    feedRateText = "F" + feedRate;
                    millingLayerName();
                    break;
                case "40%":
                    feedRate = (workspeed * 0.4).ToString();
                    txtWorkSpeed.Text = feedRate;
                    feedRateText = "F" + feedRate;
                    millingLayerName();
                    break;
                case "30%":
                    feedRate = (workspeed * 0.3).ToString();
                    txtWorkSpeed.Text = feedRate;
                    feedRateText = "F" + feedRate;
                    millingLayerName();
                    break;
                case "20%":
                    feedRate = (workspeed * 0.2).ToString();
                    txtWorkSpeed.Text = feedRate;
                    feedRateText = "F" + feedRate;
                    millingLayerName();
                    break;
                case "10%":
                    feedRate = (workspeed * 0.1).ToString();
                    txtWorkSpeed.Text = feedRate;
                    feedRateText = "F" + feedRate;
                    millingLayerName();
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
