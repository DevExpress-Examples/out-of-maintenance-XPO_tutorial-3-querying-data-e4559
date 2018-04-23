using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
namespace XpoTutorial3.DataModel {

    public partial class Customer {
        public Customer(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
