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
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Article : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Article(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue(nameof(PersistentProperty), ref _PersistentProperty, value); }
        //}

        private string _Code;
        [Size(20)]
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

        private UnitOfMeasure _UnitOfMeasure;
        [RuleRequiredField(DefaultContexts.Save)]
        public UnitOfMeasure UnitOfMeasure
        {
            get { return _UnitOfMeasure; }
            set { SetPropertyValue(nameof(UnitOfMeasure), ref _UnitOfMeasure, value); }
        }

        private Brand _Brand;
        [RuleRequiredField(DefaultContexts.Save)]
        public Brand Brand
        {
            get { return _Brand; }
            set { SetPropertyValue(nameof(Brand), ref _Brand, value); }
        }

        private Department _Department;
        [RuleRequiredField(DefaultContexts.Save)]
        public Department Department
        {
            get { return _Department; }
            set { SetPropertyValue(nameof(Department), ref _Department, value); }
        }

        private SubDepartment _SubDepartment;
        [RuleRequiredField(DefaultContexts.Save)]
        public SubDepartment SubDepartment
        {
            get { return _SubDepartment; }
            set { SetPropertyValue(nameof(SubDepartment), ref _SubDepartment, value); }
        }

        private Category _Category;
        [RuleRequiredField(DefaultContexts.Save)]
        public Category Category
        {
            get { return _Category; }
            set { SetPropertyValue(nameof(Category), ref _Category, value); }
        }

        private SubCategory _SubCategory;
        [RuleRequiredField(DefaultContexts.Save)]
        public SubCategory SubCategory
        {
            get { return _SubCategory; }
            set { SetPropertyValue(nameof(SubCategory), ref _SubCategory, value); }
        }

        //private string _PersistentProperty;        
        //[RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty
        //{
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue(nameof(PersistentProperty), ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}
    }
}