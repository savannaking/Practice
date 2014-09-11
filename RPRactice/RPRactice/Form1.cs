using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RDotNet;

namespace RPRactice
{
    public partial class Form1 : Form
    {
        private REngine engine;
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(OnFormClosed);

            REngine.SetEnvironmentVariables();
            engine = REngine.GetInstance();
            // REngine requires explicit initialization.
            // You can set some parameters.
            engine.Initialize();
        }

        private void b_eval_Click(object sender, EventArgs e)
        {
            //get input one from user input
            double[] input = Array.ConvertAll(tb_input.Text.Split(','), s => double.Parse(s));
            NumericVector group1 = engine.CreateNumericVector(input);

            //just need to assign input from here to the same variable name as in the script
            engine.SetSymbol("group1", group1);

            // Direct parsing from R script.
            NumericVector group2 = engine.Evaluate("group2 <- c(29.89, 29.93, 29.72, 29.98, 30.02, 29.98)").AsNumeric();

            // Test difference of mean and get the P-value.
            GenericVector testResult = engine.Evaluate("t.test(group1, group2)").AsList();
            double p = testResult["p.value"].AsNumeric().First();

            tb_output.Text = p.ToString();
        }

        public void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            // you should always dispose of the REngine properly.
            // After disposing of the engine, you cannot reinitialize nor reuse it
            engine.Dispose();
        }
    }
}
