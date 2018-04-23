using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using XpoTutorial3.DataModel;

namespace XpoTutorial3 {
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm {
        public XtraForm1() {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e) {
            if (xpCollection1.Count == 0) {
                var customer1 = new Customer(session1);
                customer1.Name = "John";
                customer1.Age = 21;
                customer1.Save();
                xpCollection1.Add(customer1);
                var customer2 = new Customer(session1);
                customer2.Name = "Bob";
                customer2.Age = 37;
                customer2.Save();
                xpCollection1.Add(customer2);
                var customer3 = new Customer(session1);
                customer3.Name = "Sam";
                customer3.Age = 26;
                customer3.Save();
                xpCollection1.Add(customer3);
                var customer4 = new Customer(session1);
                customer4.Name = "Bill";
                customer4.Age = 30;
                customer4.Save();
                xpCollection1.Add(customer4);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            xpCollection1.Criteria = new BinaryOperator("Age", spinEdit1.Value, BinaryOperatorType.Greater);
            gridControl1.RefreshDataSource();
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            xpCollection1.Filter = new BinaryOperator("Age", spinEdit2.Value, BinaryOperatorType.Greater);
            gridControl1.RefreshDataSource();
        }

        private void simpleButton3_Click(object sender, EventArgs e) {
            xpCollection1.Criteria = null;
            gridControl1.RefreshDataSource();
        }

        private void simpleButton4_Click(object sender, EventArgs e) {
            xpCollection1.Filter = null;
            gridControl1.RefreshDataSource();
        }
    }
}