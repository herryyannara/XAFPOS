using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XAFPOS.Module.BusinessObjects
{
    [NavigationItem("Merchandise")]    
    public class Category : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Category(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        SubDepartment _SubDepartment;
        [Association]
        public SubDepartment SubDepartment
        {
            get { return _SubDepartment; }
            set { SetPropertyValue(nameof(SubDepartment), ref _SubDepartment, value); }
        }

        private string _Code;
        [Size(10)]
        [Indexed(Unique = true)]
        [RuleRequiredField(DefaultContexts.Save)]
        public string Code
        {
            get { return _Code; }
            set { SetPropertyValue(nameof(Code), ref _Code, value); }
        }

        private string _Name;
        [Size(100)]
        [RuleRequiredField(DefaultContexts.Save)]
        public string Name
        {
            get { return _Name; }
            set { SetPropertyValue(nameof(Name), ref _Name, value); }
        }

        [Association, DevExpress.Xpo.Aggregated]
        public XPCollection<SubCategory> SubCategories
        {
            get { return GetCollection<SubCategory>(nameof(SubCategories)); }
        }
    }
}