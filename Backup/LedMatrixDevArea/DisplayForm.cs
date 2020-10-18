/*****************************************************************************/
/* Project  : LedMatrix                                                      */
/* File     : DisplayForm.cs                                                 */
/* Version  : 1                                                              */
/* Language : C#                                                             */
/* Summary  : Implementation of the demonstration interface                  */
/* Creation : 23/02/2010                                                     */
/* Autor    : Guillaume CHOUTEAU                                             */
/* History  :                                                                */
/*****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LedMatrixControlNamespace;

namespace LedMatrixDemoInterfaceNamespace
{
    /// <summary>
    /// Definition of the demonstration interface
    /// </summary>
    public partial class DisplayForm : Form
    {
      int iIdTx1;     ///<!-- Id of the text item #1 --> 
      int iIdTx2;     ///<!-- Id of the text item #2 -->
      bool m_bIsOn;   ///<!-- Flag for the Start/Stop control of the display-->
      bool m_bIsHide; ///<!-- Flag for the Show/Noshow of the control panel-->


      //-------------------------------//
      //         CONSTRUCTOR           //
      //-------------------------------//
      #region Constuctor

      /// <summary>
      /// Class constructor
      /// </summary>
      public DisplayForm()
      {
        InitializeComponent();

        // Get the color from the control
        pbtDisplayLedOn.BackColor = ledMatrixControl.LedOnColor;
        pbtDisplayLedOff.BackColor = ledMatrixControl.LedOffColor;

        // Get the size from the control
        nudDisplayNbLine.Value = ledMatrixControl.NbLedLines;
        nudDisplayNbRow.Value = ledMatrixControl.NbLedRows;
        nudLedSize.Value      = (decimal)ledMatrixControl.SizeCoeff;

        // Set the font collection
        ledMatrixControl.LoadFontCollectionFromResource("LedMatrixDevArea.LedMatrixSymbolFile.xml");

        // Add the text item to the conrol
        iIdTx1 = ledMatrixControl.AddTextItem(tbxTx1.Text, new Point(0, 0), ItemDirection.Right, ItemSpeed.Idle);
        iIdTx2 = ledMatrixControl.AddTextItem(tbxTx2.Text, new Point(0, 8), ItemDirection.Right, ItemSpeed.Idle);

        // Init the control panel
        pbtHide.Text = "Hide";
        pbtDisplayCtrl.Text = "Start";
        nudDisplayPeriod.Value = 70;
        cbxDisplayLedStyle.SelectedIndex = 0;
        cbxDirectionTx1.SelectedIndex = 0;
        cbxSpeedTx1.SelectedIndex = 1;
        nudXposTx1.Value = 0;
        nudYposTx1.Value = 0;
        cbxDirectionTx2.SelectedIndex = 0;
        cbxSpeedTx2.SelectedIndex = 1;
        nudXposTx2.Value = 0;
        nudYposTx2.Value = 8;

        // Init the flags
        m_bIsOn = false;
        m_bIsHide = false;
      }

      #endregion


      //-------------------------------//
      // Display properties events     //
      //-------------------------------//
      #region Display

      private void cbxDisplayLedStyle_SelectedIndexChanged(object sender, EventArgs e)
      {
        if (cbxDisplayLedStyle.SelectedIndex == 0)
        {
          ledMatrixControl.SetLedStyle(LedSyle.Round);
        }
        else if (cbxDisplayLedStyle.SelectedIndex == 1)
        {
          ledMatrixControl.SetLedStyle(LedSyle.Square);
        }
      }

      private void pbtDisplayLedOn_Click(object sender, EventArgs e)
      {
        ColorDialog cdLedOnColorDlg = new ColorDialog();

        if (cdLedOnColorDlg.ShowDialog() == DialogResult.OK)
        {
          pbtDisplayLedOn.BackColor = cdLedOnColorDlg.Color;
          ledMatrixControl.LedOnColor = cdLedOnColorDlg.Color;
        }
      }

      private void pbtDisplayLedOff_Click(object sender, EventArgs e)
      {
        ColorDialog cdLedOffColorDlg = new ColorDialog();

        if (cdLedOffColorDlg.ShowDialog() == DialogResult.OK)
        {
          pbtDisplayLedOff.BackColor = cdLedOffColorDlg.Color;
          ledMatrixControl.LedOffColor = cdLedOffColorDlg.Color;
        }

      }

      private void nudDisplayNbLine_ValueChanged(object sender, EventArgs e)
      {
        ledMatrixControl.SetMatrixSize((int)nudDisplayNbLine.Value, (int)nudDisplayNbRow.Value);
      }

      private void nudDisplayNbRow_ValueChanged(object sender, EventArgs e)
      {
        ledMatrixControl.SetMatrixSize((int)nudDisplayNbLine.Value, (int)nudDisplayNbRow.Value);
      }

      private void button1_Click_1(object sender, EventArgs e)
      {
        if (m_bIsOn == true)
        {
          // Stop
          ledMatrixControl.StopMove();
          pbtDisplayCtrl.Text = "Start";
          nudDisplayPeriod.Enabled = true;
          m_bIsOn = false;
        }
        else
        {
          // Start
          ledMatrixControl.StartMove((int)nudDisplayPeriod.Value);
          pbtDisplayCtrl.Text = "Stop";
          nudDisplayPeriod.Enabled = false;
          m_bIsOn = true;
        }
      }

      private void bptHide_Click(object sender, EventArgs e)
      {
        if (m_bIsHide == false)
        {

          groupBox1.Visible = false;
          groupBox2.Visible = false;
          groupBox3.Visible = false;
          pbtHide.Text = "Show";
          panel1.Height = 35;
          m_bIsHide = true;
        }
        else
        {
          groupBox1.Visible = true;
          groupBox2.Visible = true;
          groupBox3.Visible = true;
          pbtHide.Text = "Hide";
          panel1.Height = 147;
          m_bIsHide = false;
        }

      }

      private void nudLedSize_ValueChanged(object sender, EventArgs e)
      {
        ledMatrixControl.SizeCoeff = (double)nudLedSize.Value;
      }

      #endregion


      //-------------------------------//
      // Item#1 properties events     //
      //-------------------------------//
      #region Item#1

      private void tbxTx1_TextChanged(object sender, EventArgs e)
      {
        ledMatrixControl.SetItemText(iIdTx1, tbxTx1.Text);
      }

      private void cbxDirectionTx1_SelectedIndexChanged(object sender, EventArgs e)
      {
        ItemDirection newDir;
        if (cbxDirectionTx1.SelectedIndex == 0)
        {
          newDir = ItemDirection.Right;
        }
        else if (cbxDirectionTx1.SelectedIndex == 1)
        {
          newDir = ItemDirection.Left;
        }
        else if (cbxDirectionTx1.SelectedIndex == 2)
        {
          newDir = ItemDirection.Up;
        }
        else
        {
          newDir = ItemDirection.Down;
        }

        ledMatrixControl.SetItemDirection(iIdTx1, newDir);
      }

      private void cbxSpeedTx1_SelectedIndexChanged(object sender, EventArgs e)
      {
        ItemSpeed newSpeed;

        if (cbxSpeedTx1.SelectedIndex == 0)
        {
          newSpeed = ItemSpeed.Slow;
        }
        else if (cbxSpeedTx1.SelectedIndex == 1)
        {
          newSpeed = ItemSpeed.Idle;
        }
        else 
        {
          newSpeed = ItemSpeed.Fast;
        }

        ledMatrixControl.SetItemSpeed(iIdTx1, newSpeed);
      }

      private void pbtResetposTx1_Click(object sender, EventArgs e)
      {
        ledMatrixControl.SetItemLocation(iIdTx1,new Point((int)nudXposTx1.Value, (int)nudYposTx1.Value));

      }

      #endregion


      //-------------------------------//
      // Item#2 properties events     //
      //-------------------------------//
      #region Item#2

      private void tbxTx2_TextChanged(object sender, EventArgs e)
      {
        ledMatrixControl.SetItemText(iIdTx2, tbxTx2.Text);
      }

      private void cbxDirectionTx2_SelectedIndexChanged(object sender, EventArgs e)
      {
        ItemDirection newDir;
        if (cbxDirectionTx2.SelectedIndex == 0)
        {
          newDir = ItemDirection.Right;
        }
        else if (cbxDirectionTx2.SelectedIndex == 1)
        {
          newDir = ItemDirection.Left;
        }
        else if (cbxDirectionTx2.SelectedIndex == 2)
        {
          newDir = ItemDirection.Up;
        }
        else
        {
          newDir = ItemDirection.Down;
        }

        ledMatrixControl.SetItemDirection(iIdTx2, newDir);
      }

      private void cbxSpeedTx2_SelectedIndexChanged(object sender, EventArgs e)
      {
        ItemSpeed newSpeed;

        if (cbxSpeedTx2.SelectedIndex == 0)
        {
          newSpeed = ItemSpeed.Slow;
        }
        else if (cbxSpeedTx2.SelectedIndex == 1)
        {
          newSpeed = ItemSpeed.Idle;
        }
        else
        {
          newSpeed = ItemSpeed.Fast;
        }

        ledMatrixControl.SetItemSpeed(iIdTx2, newSpeed);

      }

      private void pbtResetposTx2_Click(object sender, EventArgs e)
      {
        ledMatrixControl.SetItemLocation(iIdTx2, new Point((int)nudXposTx2.Value, (int)nudYposTx2.Value));

      }
      
      #endregion

    }
}